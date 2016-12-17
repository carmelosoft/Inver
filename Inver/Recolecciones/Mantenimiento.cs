using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inver.Recolecciones
{
    public partial class Mantenimiento : Form
    {
        
        private Entidad.SiembraSet siembra;
        private Entidad.inverEntities modelo;
        private BD bd;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="titulo"></param>
        public Mantenimiento(Entidad.inverEntities modelo, BD bd, Entidad.SiembraSet siembra)
        {
            InitializeComponent();

            this.Text = "Recolecciones de " + siembra.Cultivo;
            this.siembra = siembra;
            this.modelo = modelo;
            this.bd = bd;

            // Pongo en grande y en negrita la siembra de la que estoy viendo
            btnCambioSiembra.Text = siembra.Cultivo;
        }




        /// <summary>
        /// Cerrar formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }





        /// <summary>
        /// Al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlCargarFormulario(object sender, EventArgs e)
        {
            CargaRecolecciones();
        }





        /// <summary>
        /// Carga las recolecciones aplicando el filtro
        /// </summary>
        private void CargaRecolecciones()
        {

            int TKilos = 0;
            int TKilosCobrados = 0;
            int TKilosImpagados = 0;
            decimal TCobrado = 0;
            decimal PrecioMedio = 0;
            decimal EstimadoPorCobrar = 0;
            decimal KilosMetro = 0;

            dgv.DataSource = bd.RecoleccionesListar(siembra, rbTodas.Checked, rbCobradas.Checked, rbPendientes.Checked,
                          out TKilos, out TKilosCobrados,  out TKilosImpagados, out TCobrado, out PrecioMedio, out EstimadoPorCobrar,
                          out KilosMetro);

            btnCambioSiembra.Text = siembra.Cultivo; // Pongo en el botón de cambio siembra la siembra actual

            // Muestro totales
            tbKilos.Text = TKilos.ToString();
            tbKilosCobrados.Text = TKilosCobrados.ToString();
            tbKilosImpagados.Text = TKilosImpagados.ToString();
            tbPrecioMedio.Text = PrecioMedio.ToString();
            tbEstimadoPorCobrar.Text = EstimadoPorCobrar.ToString();
            tbKilosMetro.Text = KilosMetro.ToString();        

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
        /// Agregar recoleccion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAgregarRecoleccion_Click(object sender, EventArgs e)
        {
            Recolecciones.formulario frm = new formulario(siembra,bd);

            try
            {
                if (frm.ShowDialog() == DialogResult.OK )
                {
                    Entidad.RecoleccionSet recoleccion = new Entidad.RecoleccionSet();
                    recoleccion = frm.GetRecoleccion(); 
                    bd.RecoleccionesAgregar(siembra, recoleccion);
                    CargaRecolecciones(); 
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
        /// Modificar una recolección.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            // Tomo la recolección a modificar
            Entidad.RecoleccionSet recoleccion = new Entidad.RecoleccionSet();
            Int32 idRecoleccion = (int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value;  // El ide a modificar
            recoleccion = modelo.RecoleccionSet.First(r => r.Id == idRecoleccion);

            Recolecciones.formulario frm = new formulario(siembra, recoleccion);

            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Guardar las modificaciones
                    Entidad.RecoleccionSet re = new Entidad.RecoleccionSet();
                    re = frm.GetRecoleccion();
                    bd.RecoleccionesModificar(re);
                    CargaRecolecciones();
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
        /// Borrar recolección
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            Int32 idRecoleccion = (int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value;
            Entidad.RecoleccionSet rec = new Entidad.RecoleccionSet();
            rec = bd.RecoleccionesLeer(idRecoleccion);

            // Preparo mensaje al usuario para confirmar que realmente desea borrar la recolección.
            string msj = "¿Desea realmente borrar la siguiente recolección?\n\n" +

                "Fecha : " + rec.Fecha + "\n" +
                "Comercializadora : " + rec.ComercializadoraSet.Nombre + "\n" +
                "Clasificación : " + rec.ClasificacionSet.Clase + "\n" +
                "Bultos : " + rec.Bultos.ToString() + "\n" +
                "Kilos : " + rec.Kilos.ToString() + "\n";

            if (MessageBox.Show (msj,"¡Atención!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Borrarlo
                bd.RecoleccionesBorrar(rec);
                CargaRecolecciones();
            }
        }



        /// <summary>
        /// Cambiar de Siembra
        /// 
        /// El usuario quiere cambiar a otra siembra, se despliega un formulario
        /// al que se puede seleccionar alguna de las siembras activas actualmente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCambioSiembra_Click(object sender, EventArgs e)
        {
            List<Entidad.SiembraSet> siembrasActivas = new List<Entidad.SiembraSet>();
            siembrasActivas = bd.SiembrasListar(false, true, false);

            SeleccionSiembra frm = new SeleccionSiembra(siembrasActivas, bd);
            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // cambiar a la siembra seleccionada                    
                    siembra = frm.GetSiembraSeleccionada;
                    CargaRecolecciones();

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                frm.Close();
            }
        }
    }
}
