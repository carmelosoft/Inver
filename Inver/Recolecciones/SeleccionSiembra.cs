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
    public partial class SeleccionSiembra : Form
    {
        // Atributos privados
        private List<Entidad.SiembraSet> siembras;
        private BD bd;




        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="siembras"></param>
        public SeleccionSiembra(List<Entidad.SiembraSet> siembras, BD bd)
        {
            InitializeComponent();

            this.siembras = siembras;
            this.bd = bd;
        }



        /// <summary>
        /// Devuelve la siembra que se ha seleccionado
        /// </summary>
        public Entidad.SiembraSet GetSiembraSeleccionada
        {
            get
            {
                return bd.SiembrasLeeSiembra((int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value);
            }
        }



        /// <summary>
        /// Al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeleccionSiembra_Load(object sender, EventArgs e)
        {
            CargaSiembras();
        }


        private void CargaSiembras()
        {
            dgv.DataSource = siembras;
        }



        /// <summary>
        /// Ha escogido una siembra para cambiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
