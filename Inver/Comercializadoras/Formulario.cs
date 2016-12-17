using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inver.Comercializadoras
{
    public partial class Formulario : Form
    {

        private Entidad.ComercializadoraSet comercializadora;



        public Formulario(string Titulo)
        {
            InitializeComponent();

            this.Text = Titulo;
            comercializadora = new Entidad.ComercializadoraSet();
        }




        /// <summary>
        /// Devuelve el nombre de la comercializadora
        /// </summary>
        public string GetNombreComercializadora
        {
            get { return tbComercializadora.Text.ToString(); }
        }




        /// <summary>
        /// La comisión de la comercializadora
        /// </summary>
        public short GetComisionComercializadora
        {
            get
            {
                return (Convert.ToInt16(tbComision.Text));
            }
        }
        



        /// <summary>
        /// Devuelve o establece la comercializadora
        /// </summary>
        public Entidad.ComercializadoraSet GetSetComercializadora
        {
            get
            {
                comercializadora.Nombre = tbComercializadora.Text.ToString();
                comercializadora.Comision = Convert.ToInt16(tbComision.Text);

                return comercializadora;
            }

            set
            {
                tbComercializadora.Text = value.Nombre;
                tbComision.Text = value.Comision.ToString();
                this.comercializadora = value;
               
            }
        }
    }
}
