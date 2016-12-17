using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inver
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }




        public string usuario
        {
            get { return tbUsuario.Text; }
        }



        public string clave
        {
            get
            {
                return tbClave.Text;
            }
        }
    }
}
