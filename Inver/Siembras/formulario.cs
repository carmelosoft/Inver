using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inver.Entidad;

namespace Inver.Siembras
{
    public partial class formulario : Form
    {
        private SiembraSet siembra;



        /// <summary>
        /// Constructgor
        /// </summary>
        /// <param name="siembra"></param>
        public formulario(string titulo, SiembraSet siembra)
        {
            InitializeComponent();

            this.siembra = siembra;

            this.Text = titulo;

            dtpFecha.Value = siembra.Fecha;
            tbCultivo.Text = siembra.Cultivo;
            tbPlantas.Text = siembra.Plantas.ToString();
            tbSuperficie.Text = siembra.Superficie.ToString();
        }



        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="titulo"></param>
        public formulario(string titulo)
        {
            InitializeComponent();

            this.Text = titulo;
        }



        /// <summary>
        /// Devuelve una entidad "Siembra" con los datos del formulario
        /// </summary>
        public Entidad.SiembraSet GetSiembra
        {
            get
            {
                Entidad.SiembraSet siembra = new Entidad.SiembraSet();
                siembra.Activa = true; // Por defecto la siembra que se crea es activa
                siembra.Fecha = dtpFecha.Value;
                siembra.Cultivo = tbCultivo.Text;
                siembra.Superficie = Convert.ToInt16(tbSuperficie.Text);
                siembra.Plantas = Convert.ToInt16(tbPlantas.Text);

                return siembra;
            }
        }
    }
}
