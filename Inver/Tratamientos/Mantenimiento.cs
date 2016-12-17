using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inver.Tratamientos
{
    public partial class Mantenimiento : Form
    {
        private Entidad.UsuarioSet usuario;
        private Entidad.SiembraSet siembra;
        private BD bd;

        /// <summary>
        /// Constructor
        /// </summary>
        public Mantenimiento(Entidad.UsuarioSet usuario, Entidad.SiembraSet siembra, BD bd)
        {
            InitializeComponent();

            this.usuario = usuario;
            this.siembra = siembra;
            this.bd = bd;

        }



        /// <summary>
        /// Cerrar ventana
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
            lbTitulo.Text = "Tratamientos de : " + siembra.Cultivo;

            CargaTratamientos();
        }




        /// <summary>
        /// Carga los tratamientos
        /// </summary>
        private void CargaTratamientos()
        {
            dgv.DataSource = bd.TratamientosListar(siembra);

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
        /// Al pinchar con el raton 1 Click mostrar la descripción del tratamiento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_MouseClick(object sender, MouseEventArgs e)
        {
            tbDescripcion.Text = dgv["ColumDescripcion", dgv.CurrentCell.RowIndex].Value.ToString();
        }



        /// <summary>
        /// Agregar un tratamiento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            Formulario frm = new Formulario("Alta de Tratamiento");

            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Anotar el tratamiento
                    Entidad.TratamientoSet tratamiento = new Entidad.TratamientoSet();
                    tratamiento.Fecha = frm.GetFecha;
                    tratamiento.Descripcion = frm.GetDescripcion;
                    tratamiento.SiembraId = siembra.Id;

                    bd.TratamientosAgregar(tratamiento);

                    CargaTratamientos();
                    tbDescripcion.Text = "\n\nSeleccione una fecha de tratamiento para visualizarlo";
                    
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                frm.Close();
            }
        }



        /// <summary>
        /// modificar el tratamiento indicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            int idTratamiento = (int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value;
            Entidad.TratamientoSet tratamiento = new Entidad.TratamientoSet();
            tratamiento = bd.TratamientosLee(idTratamiento);

            Formulario frm = new Formulario("Modificar tratamiento");
            frm.SetFecha = tratamiento.Fecha;
            frm.SetDescripcion = tratamiento.Descripcion;

            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Modificar el tratamiento
                    tratamiento.Fecha = frm.GetFecha;
                    tratamiento.Descripcion = frm.GetDescripcion;
                    bd.GuardarModificaciones();
                    CargaTratamientos();
                    tbDescripcion.Text = "\n\nSeleccione una fecha de tratamiento para visualizarlo";
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                frm.Close();
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        /// <summary>
        /// Borrar el tratamiento seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            int idTratamiento = (int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value;
            Entidad.TratamientoSet tratamiento = new Entidad.TratamientoSet();
            tratamiento = bd.TratamientosLee(idTratamiento);

            string msj = "¿Desea borrar este tratamiento?\n\n" +
                "Fecha: " + tratamiento.Fecha.ToShortDateString() +
                "\nTratamiento: " + tratamiento.Descripcion;

            if (MessageBox.Show (msj,"¡Atención!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bd.TratamientosBorrar(tratamiento);
                CargaTratamientos();
                tbDescripcion.Text = "\n\nSeleccione una fecha de tratamiento para visualizarlo";
            }
        }
    }
}
