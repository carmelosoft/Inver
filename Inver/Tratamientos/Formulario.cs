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
    public partial class Formulario : Form
    {




        /// <summary>
        /// Constructor para Altas
        /// </summary>
        /// <param name="titulo"></param>
        public Formulario(string titulo)
        {
            InitializeComponent();

            this.Text = titulo;
            dtpFecha.Value = DateTime.Now;
        }



        /// <summary>
        /// Establece la fecha
        /// </summary>
        public DateTime SetFecha
        {
            set { dtpFecha.Value = value; }
        }


        /// <summary>
        /// Establece la descripción del tratamiento
        /// </summary>
        public string SetDescripcion
        {
            set
            {
                tbDescripcion.Text = value;
            }
        }

        /// <summary>
        /// La fecha del tratamiento
        /// </summary>
        public DateTime GetFecha
        {
            get { return dtpFecha.Value; }
        }


        /// <summary>
        /// La descripción del tratamiento
        /// </summary>
        public string GetDescripcion
        {
            get
            {
                return tbDescripcion.Text;
            }
        }


    }
}
