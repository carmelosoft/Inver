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
    public partial class Formulario : Form
    {
        public Formulario(string Titulo)
        {
            InitializeComponent();

            this.Text = Titulo;

        }





        /// <summary>
        /// Devuelve la entidad de clasificación
        /// </summary>
        public Entidad.ClasificacionSet Clasificacion
        {
            get
            {
                Entidad.ClasificacionSet cl = new Entidad.ClasificacionSet();
                cl.Clase = tbClasificacion.Text.ToString();
                return cl;
            }
            set
            {
                tbClasificacion.Text = value.Clase;
            }

        }
    }
}
