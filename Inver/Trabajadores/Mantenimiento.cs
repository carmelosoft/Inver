using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inver.Trabajadores
{
    public partial class Mantenimiento : Form
    {
        private Entidad.UsuarioSet usuario;
        private BD bd;




        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="usuario"></param>
        public Mantenimiento(Entidad.UsuarioSet usuario, BD bd)
        {
            InitializeComponent();

            this.usuario = usuario;
            this.bd = bd;
        }




        /// <summary>
        /// Salir del mantenimiento de trabajadores
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
            CargaTrabajadores();
        }



        /// <summary>
        /// Carga la lista de trabajadores
        /// </summary>
        private void CargaTrabajadores()
        {
            dgv.DataSource = bd.TrabajadoresListar(usuario);
            if (dgv.RowCount != 0 )
            {
                tsbModificar.Enabled = true;
                tsbPapelera.Enabled = true;
            } else
            {
                tsbModificar.Enabled = false;
                tsbPapelera.Enabled = false;
            }
        }




        /// <summary>
        /// Agregar un nuevo trabajador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            formulario frm = new formulario("Agregar nuevo Trabajador");
            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Entidad.TrabajadorSet trabajador = new Entidad.TrabajadorSet();
                    trabajador.UsuarioId = usuario.Id;
                    trabajador.Nombre = frm.GetNombreTrabajador;
                    bd.TrabajadoresAgregar(usuario, trabajador);
                    CargaTrabajadores();
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
        /// Modificar trabajador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            // Selecciono el trabajador
            int idTrabajador = (int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value;
            Entidad.TrabajadorSet trabajador = new Entidad.TrabajadorSet();
            trabajador = bd.TrabajadoresLee(idTrabajador);

            // Muestro al usuario el trabajador para que lo modifique
            Trabajadores.formulario frm = new formulario("Modificar trabajador: " + trabajador.Nombre);
            frm.SetNombreTrabajador = trabajador.Nombre;

            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Modificarlo                    
                    bd.TrabajadoresModificar(trabajador, frm.GetNombreTrabajador);
                    CargaTrabajadores();
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
        /// Borrar el trabajador seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbPapelera_Click(object sender, EventArgs e)
        {
            // Tomo los datos del trabajador a borrar
            int idTrabajador = (int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value;
            string nombreTrabajador = bd.TrabajadoresGetNombre(idTrabajador);

            // Pregunto si desea borrarlo
            string msj = "¿Desea realmente borrar el siguiente trabajador?\n\n" + nombreTrabajador;
            if (MessageBox.Show (msj,"¡Atención!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Borrarlo
                bd.TrabajadoresBorrar(idTrabajador);
                CargaTrabajadores();
            }
        }
    }
}
