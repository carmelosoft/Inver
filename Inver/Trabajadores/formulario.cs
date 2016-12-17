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
    public partial class formulario : Form
    {
        public formulario(string Titulo)
        {
            InitializeComponent();

            this.Text = Titulo;
        }



        /// <summary>
        /// Optiene el nombre del trabajador.
        /// </summary>
        public string GetNombreTrabajador
        {
            get
            {
                return tbTrabajador.Text;
            }
        }



        /// <summary>
        /// Establece el nombre del trabajador
        /// </summary>
        public string SetNombreTrabajador
        {
            set
            {
                tbTrabajador.Text = value;
            }
        }
    }
}
