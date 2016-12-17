using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inver.Clasificaciones
{
    public partial class Mantenimiento : Form
    {
        private Entidad.inverEntities modelo;
        private BD bd;




        /// <summary>
        /// Constructor
        /// </summary>
        public Mantenimiento(Entidad.inverEntities modelo, BD bd)
        {
            InitializeComponent();

            this.modelo = modelo;
            this.bd = bd;
        }




        /// <summary>
        /// Cerrar formulario
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
        private void AlCargarElFormulario(object sender, EventArgs e)
        {
            CargaSiembras();
        }



        /// <summary>
        /// Carga las siembras activas
        /// </summary>
        private void CargaSiembras()
        {
            cbSiembras.DataSource = bd.SiembrasListar(false, true, false);

            
        }



        /// <summary>
        /// Al cambiar de siembra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CambioDeSiembra(object sender, EventArgs e)
        {
            CargaClasificaciones();
            
        }



        /// <summary>
        /// Carga las clasificaciones de la siembra seleccioonada
        /// </summary>
        private void CargaClasificaciones( )
        {
            dgv.DataSource = bd.ClasificacionesListar((int)cbSiembras.SelectedValue);

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
        /// Agregar una clasificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            Clasificaciones.Formulario frm = new Formulario("Agregar una Clasificación de género");
           

            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Entidad.ClasificacionSet clasificacion = new Entidad.ClasificacionSet();
                    clasificacion = frm.Clasificacion;
                    clasificacion.SiembraSet = modelo.SiembraSet.First(s => s.Id == (int)cbSiembras.SelectedValue);
                    clasificacion.SiembraId = clasificacion.SiembraSet.Id;
                    
                    modelo.ClasificacionSet.Add(clasificacion);
                    modelo.SaveChanges();
                    CargaClasificaciones();
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                frm.Close();
            }
        }



        /// <summary>
        /// Modificar la clasificación seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            Entidad.ClasificacionSet clasificacionOld = new Entidad.ClasificacionSet();
            clasificacionOld = bd.ClasificacionesLee((int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value);

            Clasificaciones.Formulario frm = new Formulario("Modificar Clasificación género");
            frm.Clasificacion = clasificacionOld;
            

            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Modificarla
                    Entidad.ClasificacionSet clasificacion = new Entidad.ClasificacionSet();
                    clasificacion = frm.Clasificacion;
                    bd.ClasificacionesModificar(clasificacionOld, clasificacion);
                    CargaClasificaciones();
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
        /// Borrar la clasificación seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            // Cargo la clasificación
            Int32 idClaseficacion = (int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value;
            Entidad.ClasificacionSet clasificacion = new Entidad.ClasificacionSet();
            clasificacion = bd.ClasificacionesLee(idClaseficacion);

            if (clasificacion.RecoleccionSet.Count != 0)
            {
                MessageBox.Show("No puede borrar esta clasificación porque hay recolecciones asignadas",
                    "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;

            }


            // Pregunto al usuario si desea borrarla
            string msj = "¿Desea borrar esta clasificación?\n\n" + clasificacion.Clase;
            if (MessageBox.Show (msj,"¡Atención!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {


                // Borrarla
                bd.ClasificacionesBorrar(idClaseficacion);
                CargaClasificaciones();
            }
        }
    }
}
