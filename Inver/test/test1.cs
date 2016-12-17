using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inver.test
{
    public partial class test1 : Form
    {
        private Entidad.inverEntities modelo;
        private BD bd;


        public test1(Entidad.inverEntities modelo, BD bd)
        {
            InitializeComponent();

            this.modelo = modelo;
            this.bd = bd;
            
        }



        /// <summary>
        /// Al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void test1_Load(object sender, EventArgs e)
        {
            // Tomo las siembras
            List<Entidad.SiembraSet> siembras = new List<Entidad.SiembraSet>();
            siembras = modelo.SiembraSet.ToList();

            // Visualizo las siembras

            label1.Text = "Siembras";
            dgv.DataSource = siembras;


            // Recolecciones
            List<Entidad.RecoleccionSet> recolecciones = new List<Entidad.RecoleccionSet>();
            recolecciones = modelo.RecoleccionSet.ToList();
            dgvr.DataSource = recolecciones;


           
        }


        /// <summary>
        /// Agregar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Tomo la primera siembra
            Entidad.SiembraSet siembra1 = new Entidad.SiembraSet();
            siembra1 = modelo.SiembraSet.First(s => s.Id == 1);

            // comercializadora cojo la primera
            Entidad.ComercializadoraSet comercializadora = new Entidad.ComercializadoraSet();
            comercializadora = siembra1.ComercializadoraSet.First(c => c.Id == 3);

            // Clasificación cojo la primera
            Entidad.ClasificacionSet clasificacion1 = new Entidad.ClasificacionSet();
            clasificacion1 = siembra1.ClasificacionSet.First(c => c.Id == 1);


            // Nueva recolección
            Entidad.RecoleccionSet rec = new Entidad.RecoleccionSet();
            rec.Fecha = DateTime.Now;
            rec.Kilos = 1;
            rec.Bultos = 2;
            rec.Precio = 3;
            rec.Cobrado = false;
            rec.SiembraId = siembra1.Id;
            rec.SiembraSet = siembra1;
            rec.ComercializadoraId = comercializadora.Id;
            rec.ComercializadoraSet = comercializadora;
            rec.ClasificacionSet = clasificacion1;
            rec.ClasificacionId = clasificacion1.Id;
                    
               




            try
            {
                modelo.RecoleccionSet.Add(rec);
                modelo.SaveChanges();
                dgvr.Refresh();
               // dgvr.DataSource = modelo.RecoleccionSet.ToList();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }
    }
}
