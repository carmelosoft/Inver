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
    public partial class formulario : Form
    {
        
        private Entidad.SiembraSet siembra;
        private Entidad.RecoleccionSet recoleccion;
        private Boolean modificando;
        private BD bd;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="siembra"></param>
        public formulario(Entidad.SiembraSet Siembra, BD bd)
        {
            InitializeComponent();
                    
            this.siembra = Siembra;
            this.bd = bd;
            this.Text = "Recolección de : " + this.siembra.Cultivo;

            modificando = false;
            this.recoleccion = new Entidad.RecoleccionSet();
        }



        /// <summary>
        /// Constructor para modificación, se le pasa la recolección a mmodificar
        /// </summary>
        /// <param name="Siembra"></param>
        /// <param name=""></param>
        public formulario(Entidad.SiembraSet Siembra, Entidad.RecoleccionSet recoleccion)
        {
            InitializeComponent();

            this.siembra = Siembra;
            this.recoleccion = recoleccion;

            this.Text = "Recolección de : " + this.siembra.Cultivo;

            modificando = true;
        }



        /// <summary>
        /// Devuelve la fecha
        /// </summary>
        public DateTime GetFecha
        {
            get { return dtpFecha.Value; }
        }


        /// <summary>
        /// Al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlCargarFormulario(object sender, EventArgs e)
        {
            CargaComercializadoras();
            CargaClasificaciones();

            if (modificando)
            {
                // Muestro los datos a modificar
                dtpFecha.Value = recoleccion.Fecha;
                cbComercializadora.SelectedValue = recoleccion.ComercializadoraId;
                cbClasificacion.SelectedValue = recoleccion.ClasificacionId;
                tbBultos.Text = recoleccion.Bultos.ToString();
                tbKilos.Text = recoleccion.Kilos.ToString();
                tbPrecio.Text = recoleccion.Precio.ToString();
                chbCobrado.Checked = recoleccion.Cobrado;
            }
        }



        /// <summary>
        /// Carga las comercializadoras asignadas a la siembra
        /// </summary>
        private void CargaComercializadoras()
        {            
            cbComercializadora.DataSource = siembra.ComercializadoraSet.ToList();
        }



        private void CargaClasificaciones()
        {

            cbClasificacion.DataSource = siembra.ClasificacionSet.ToList();
        }




        /// <summary>
        /// hA ACEPTADO LOS DATOS.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btOk_Click(object sender, EventArgs e)
        {

        }





        /// <summary>
        /// Devuelve una entidad recolección con todos los datos que ha proporcionado el usuario
        /// </summary>
        /// <returns></returns>
        public Entidad.RecoleccionSet GetRecoleccion ()
        {
            

            Entidad.RecoleccionSet recoleccion = new Entidad.RecoleccionSet();

            // Id
            recoleccion.Id = this.recoleccion.Id;

            // Fecha
            recoleccion.Fecha = dtpFecha.Value;

            // Comercializadora
            recoleccion.ComercializadoraSet = siembra.ComercializadoraSet.First(x => x.Id == (int)cbComercializadora.SelectedValue);
            recoleccion.ComercializadoraId = recoleccion.ComercializadoraSet.Id;

            // Clasificacion
            recoleccion.ClasificacionSet = siembra.ClasificacionSet.First(x => x.Id == (int)cbClasificacion.SelectedValue);
            recoleccion.ClasificacionId = recoleccion.ClasificacionSet.Id;

            // bultos
            recoleccion.Bultos = Convert.ToInt16(tbBultos.Text);

            // kilos
            recoleccion.Kilos = Convert.ToInt16(tbKilos.Text);

            // precio
            recoleccion.Precio = Convert.ToDecimal(tbPrecio.Text);

            // cobrado
            recoleccion.Cobrado = chbCobrado.Checked;

            // SiembraId
            recoleccion.SiembraId = siembra.Id; // Siembra a la que pertenece la recolección.

            recoleccion.SiembraSet = siembra;//

            return recoleccion;
        }



        

        /// <summary>
        /// Crear una nueva comercializadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearComercializadora_Click(object sender, EventArgs e)
        {
            Comercializadoras.Formulario frm = new Comercializadoras.Formulario("Crear Comercializadora");

            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Agregar la nueva comercializadora
                    Entidad.ComercializadoraSet co = new Entidad.ComercializadoraSet();
                    co = frm.GetSetComercializadora;                   
                    co.SiembraSet = siembra;
                    co.SiembraId = siembra.Id;
                    Int32 id = bd.ComercializadorasInserta(co); // Agrego a BD


                    // Seleccionar la comercializadora creada
                    CargaComercializadoras();
                    cbComercializadora.SelectedValue = 5;    

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
        /// Crear una nueva clasificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearClasificacion_Click(object sender, EventArgs e)
        {
            Clasificaciones.Formulario frm = new Clasificaciones.Formulario("Crear nueva Clasificacion");

            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Agregar la nueva clasificacion
                    Entidad.ClasificacionSet cl = new Entidad.ClasificacionSet();
                    cl = frm.Clasificacion;
                    cl.SiembraSet = siembra;
                    cl.SiembraId = siembra.Id;
                    Int32 id = bd.ClasificacionesInserta(cl);


                    // Seleccionar la clasificación creada
                    CargaClasificaciones();
                    cbClasificacion.SelectedValue = id;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                frm.Close();
            }
        }
    }
}
