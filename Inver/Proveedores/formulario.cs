using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inver.Proveedores
{
    public partial class formulario : Form
    {



        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Titulo"></param>
        public formulario(string Titulo)
        {
            InitializeComponent();

            this.Text = Titulo;
        }






        /// <summary>
        /// Devuelve el nombre del proveedor
        /// </summary>
        public string GetNombreProveedor
        {
            get
            {
                return tbProveedor.Text;
            }
        }





        /// <summary>
        /// Establece el nombre del proveedor
        /// </summary>
        public string SetNombreProveedor
        {
            set
            {
                tbProveedor.Text = value;
            }
        }




    }
}
