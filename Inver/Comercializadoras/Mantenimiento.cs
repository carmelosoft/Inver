using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inver.Comercializadoras
{
    public partial class Mantenimiento : Form
    {

        private Entidad.inverEntities modelo;
        private BD bd;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="titulo"></param>
        public Mantenimiento(string titulo, Entidad.inverEntities modelo, BD bd)
        {
            InitializeComponent();

            this.Text = titulo;
            this.modelo = modelo;
            this.bd = bd;
        }



        /// <summary>
        /// Cerrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }



        /// <summary>
        /// Al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            cargaSiembras();

        }



        /// <summary>
        /// Carga en el comboBox la lista de  siembras activas
        /// </summary>
        private void cargaSiembras()
        {
            cbSiembras.DataSource = modelo.SiembraSet.Where(s => s.Activa == true).ToList();

            // Si no existen siembras no se pueden agregar comercializadoras, ya que las comercializadoras están asociadas con la siembra
            if (cbSiembras.Items.Count != 0)
            {
                tsbAgregar.Enabled = true;
            } else
            {
                tsbAgregar.Enabled = false;
            }
        }





        /// <summary>
        /// Al cambiar de siembra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CambioDeSiembra(object sender, EventArgs e)
        {
            // Tomo la siembra seleccionada
            Entidad.SiembraSet siembra = (Entidad.SiembraSet)cbSiembras.SelectedItem;

            // Cargo la lista de comercializadoras para esta siembra
            dgv.DataSource = siembra.ComercializadoraSet.ToList(); 


            if (dgv.RowCount != 0)
            {
                tsbModificar.Enabled = true;
                tsbBorrar.Enabled = true;
            } else
            {
                tsbModificar.Enabled = false;
                tsbBorrar.Enabled = false;
            }
        }



        /// <summary>
        /// Agregar una nueva comercializadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            Formulario frm = new Formulario("Agregar Comercializadora");

            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Entidad.ComercializadoraSet comercializadora = frm.GetSetComercializadora;
                    Entidad.SiembraSet siembra = new Entidad.SiembraSet();
                    siembra = (Entidad.SiembraSet)cbSiembras.SelectedItem;
                    comercializadora.SiembraSet = siembra;
                    comercializadora.SiembraId = siembra.Id;
                    bd.ComercializadorasInserta(comercializadora);
                    CambioDeSiembra(sender, e); // Cargar lista de comercializadoras
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                frm.Close();
            }
        }



        /// <summary>
        /// Modificar el nombre de una comercializadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            // tomo el ide de la comercializadora a modificar
            Int32 idComercializadora = (int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value;

            // La leo
            Entidad.ComercializadoraSet comercializadora = new Entidad.ComercializadoraSet();
            comercializadora = bd.ComercializadorasLee(idComercializadora);

            // Muestro formulario para que el usuario pueda modificar 
            Formulario frm = new Formulario("Modificar comercializadora");
            frm.GetSetComercializadora = comercializadora; // Paso la comercializadora al formulario
            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Guardar cambios en comercializadora
                    bd.ComercializadorasModificar(idComercializadora, frm.GetNombreComercializadora, frm.GetComisionComercializadora);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                frm.Close();
            }
        }





        /// <summary>
        /// Borrar comercializadora indicada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            // tomo el ide de la comercializadora a modificar
            Int32 idComercializadora = (int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value;

            // La leo
            Entidad.ComercializadoraSet comercializadora = new Entidad.ComercializadoraSet();
            comercializadora = bd.ComercializadorasLee(idComercializadora);

            // Verifico que no tenga la comercializadora recolecciones asignadas para poder borrarla
            if (comercializadora.RecoleccionSet.Count != 0)
            {
                MessageBox.Show("No puede borrar una comercializadora que tiene recolecciones asignadas",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            // Preparo mensaje para preguntar al usuario si realmente quiere borrar la comercializadora seleccionada
            string msj = "¿Desea realmente borrar la siguiente comercializadora?\n\n" + comercializadora.Nombre;


            // Pregunto
            if (MessageBox.Show (msj,"¡Atención!",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Borrarla
                bd.ComercializadorasBorrar(idComercializadora);
                CambioDeSiembra(sender, e); // Recarga comercializadoras
            }
        }
    }
}
