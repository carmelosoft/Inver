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
    public partial class Mantenimiento : Form
    {
        private Entidad.inverEntities modelo;
        private BD bd;
        private Entidad.UsuarioSet usuario;





        /// <summary>
        /// Constructor
        /// </summary>
        public Mantenimiento(Entidad.inverEntities modelo, BD bd, Entidad.UsuarioSet usuario)
        {
            InitializeComponent();

            this.modelo = modelo;
            this.bd = bd;
            this.usuario = usuario;
        }




        /// <summary>
        /// Cerrar formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }




        /// <summary>
        /// Al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            CargaProveedores();
            
        }




        /// <summary>
        /// Actualiza la vista de proveedores
        /// </summary>
        private void CargaProveedores ()
        {
            dgv.DataSource = bd.ProveedoresListar(usuario);
            if (dgv.RowCount != 0)
            {
                tsbModificar.Enabled = true;
                tsbBorrar.Enabled = true;
            } else
            {
                tsbModificar.Enabled = false;
                tsbBorrar.Enabled = false;
            }
        }




        /// <summary>
        /// Agregar un nuevo proveedor
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            formulario frm = new formulario("Alta de nuevo proveedor");
            
            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Agregar el proveedor
                    Entidad.ProveedorSet proveedor = new Entidad.ProveedorSet();
                    proveedor.UsuarioId = usuario.Id;
                    proveedor.Nombre = frm.GetNombreProveedor;
                    bd.ProveedoresAgregar(usuario, proveedor);
                    CargaProveedores();   
                }
            }  catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                frm.Close();
            }
        }






        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        /// <summary>
        /// Modirficar el proveedor seleccionado en el dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            // Leo el proveedor
            int idProveedor = (int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value;
            Entidad.ProveedorSet proveedor =  bd.ProveedoresLee(idProveedor);

            // Ya tengo el proveedor, ahora muestro el formulario para que pueda modificarlo
            formulario frm = new formulario("Modificar Proveedor: " + proveedor.Nombre);
            frm.SetNombreProveedor = proveedor.Nombre;

            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Guardar modificaciones
                    bd.ProveedoresModifica(proveedor, frm.GetNombreProveedor);

                    // Actualizar listado proveedores
                    CargaProveedores();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                frm.Close();
            }

        }




        /// <summary>
        /// Borrar el proveedor seleccionado en en dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            int idProveedor = (int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value;
            Entidad.ProveedorSet proveedor = bd.ProveedoresLee(idProveedor);

            // Muestro mensaje al usuario y pido confirmación de borrado
            string msj = "¿Desea borrar el siguiente proveedor?\n\n" + proveedor.Nombre;

            if (MessageBox.Show (msj,"¡Atención!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bd.ProveedoresBorrar(proveedor);
                CargaProveedores();
            }
        }
    }
}
