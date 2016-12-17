using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inver.Gastos.Genericos
{
    public partial class Formulario : Form
    {
        private Entidad.UsuarioSet usuario;
        private BD bd;
        



        /// <summary>
        /// Constructor
        /// </summary>
        public Formulario(Entidad.UsuarioSet usuario, BD bd, string Titulo)
        {
            InitializeComponent();

            this.usuario = usuario;
            this.bd = bd;

        }




        
        public DateTime SetFecha { set { dtpFecha.Value = value; } }
        public string SetConcepto { set { tbConcepto.Text = value; } }
        public decimal SetImporte { set { tbImporte.Text = value.ToString(); } }
        public bool SetPagado { set { chbPagado.Checked = value; } }
        public int SetIdProveedor { set { cbProveedor.SelectedValue = value; } }
        public int SetIdTrabajador { set { cbTrabajador.SelectedValue = value; } }





        /// <summary>
        /// Recupera el identificador del trabajador.
        /// </summary>
        public int GetIdTrabajador
        {
            get
            {
                return (int)cbTrabajador.SelectedValue;
            }
        }



        /// <summary>
        /// Recupera el identificador del proveedor seleccionado
        /// </summary>
        public int GetIdProveedor {
            get {
                return (int)cbProveedor.SelectedValue;
            }
        }



        /// <summary>
        /// El nombre del trabajador seleccionado
        /// </summary>
        public string GetNombreTrabajador
        {
            get { return cbTrabajador.SelectedValue.ToString(); }
        }


        /// <summary>
        /// El nombre del proveedor seleccionado
        /// </summary>
        public string GetNombreProveedor
        {
            get
            {
                return cbProveedor.SelectedValue.ToString();
            }
        }



        /// <summary>
        /// El estado de pago del gasto
        /// </summary>
        public bool GetPagado
        {
            get
            {
                return chbPagado.Checked;
            }
        }



        /// <summary>
        /// El importe del gasto
        /// </summary>
        public decimal GetImporte
        {
            get
            {
                return Convert.ToDecimal(tbImporte.Text);
            }
        }


        /// <summary>
        /// El concepto de gasto
        /// </summary>
        public string GetConcepto
        {
            get
            {
                return tbConcepto.Text;
            }
        }


        /// <summary>
        /// La fecha del gasto
        /// </summary>
        public DateTime GetFecha
        {
            get
            {
                return (dtpFecha.Value);
            }
        }



        /// <summary>
        /// Al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Formulario_Load(object sender, EventArgs e)
        {
            CargaProveedores();
            CargaTrabajadores();
        }




        /// <summary>
        /// Carga en el comboBox de trabajadores los trabajadores que tenga el usuario
        /// </summary>
        private void CargaTrabajadores ()
        {
            cbTrabajador.DataSource = bd.TrabajadoresListar(usuario);
        }





        /// <summary>
        /// Carga en el comboBox los proveedores
        /// </summary>
        private void CargaProveedores()
        {
            cbProveedor.DataSource = bd.ProveedoresListar(usuario);
        }



        /// <summary>
        /// El usuario quiere agregar un nuevo proveedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            Proveedores.formulario frm = new Proveedores.formulario("Agregar proveedor");

            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Agregar el proveedor
                    Entidad.ProveedorSet prov = new Entidad.ProveedorSet();
                    prov.Nombre = frm.GetNombreProveedor;
                    prov.UsuarioId = usuario.Id;
                    bd.ProveedoresAgregar(usuario, prov);
                    // Actualizar el comboBox de proveedores
                    CargaProveedores();

                    // seleccionarlo
                    cbProveedor.SelectedValue = prov.Id;
                }
            } catch (Exception ex)
            {
                MessageBox.Show
                    (ex.Message);
            } finally
            {
                frm.Close();
            }
        }




        /// <summary>
        /// Agregar un nuevo trabajador y seleccionarlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarTrabajador_Click(object sender, EventArgs e)
        {
            Trabajadores.formulario frm = new Trabajadores.formulario("Agregar Trabajador");
            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Agrego el trabajador
                    Entidad.TrabajadorSet trab = new Entidad.TrabajadorSet();
                    trab.Nombre = frm.GetNombreTrabajador;
                    trab.UsuarioId = usuario.Id;
                    bd.TrabajadoresAgregar(usuario, trab);
                    // Actualizo comboBox
                    CargaTrabajadores();
                    // Selecciono el trabajador agregado
                    cbTrabajador.SelectedValue = trab.Id;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                frm.Close();
            }
        }
    }
}
