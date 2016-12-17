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
    public partial class Mantenimiento : Form
    {
        private BD bd;
        private Entidad.inverEntities modelo;
        private Entidad.UsuarioSet usuario;



        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="modelo"></param>
        /// <param name="bd"></param>
        public Mantenimiento(Entidad.inverEntities modelo, BD bd, Entidad.UsuarioSet usuario)
        {
            InitializeComponent();

            this.bd = bd;
            this.modelo = modelo;
            this.usuario = usuario;
        }




        /// <summary>
        /// Cierra el mantenimiento de gastos genéricos
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }





        /// <summary>
        /// Al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlCargarFormulario(object sender, EventArgs e)
        {
            CargaSetting();
            CargaGastosGenericos();
        }




        /// <summary>
        /// Carga los gastos genéricos según el intervalo indicado
        /// </summary>
        private void CargaGastosGenericos()
        {
            Clases.TotalGastos totales = new Clases.TotalGastos();

            dgv.DataSource = bd.GtoGenericoListar(dtpFechaInicial.Value, dtpFechaFinal.Value, usuario, ref totales);

            if (dgv.RowCount != 0)
            {
                tsbModificar.Enabled = true;
                tsbBorrar.Enabled = true;
            }
            else
            {
                tsbModificar.Enabled = false;
                tsbBorrar.Enabled = false;
            }

            // Muestro totales de gastos
            tbSumaGastos.Text = totales.Suma.ToString("c");
            tbPagado.Text = totales.Pagados.ToString("c");
            tbPendiente.Text = totales.Pendiente.ToString("c");
        }







        /// <summary>
        /// Carga los datos de configuración anteriores
        /// </summary>
        private void CargaSetting()
        {
            dtpFechaInicial.Value = Settings.Default.mantenimientoGastoGenericoFecha1;
            dtpFechaFinal.Value = Settings.Default.mantenimientoGastoGenericoFecha2;
        }




        /// <summary>
        /// Al cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlCerrarFormulario(object sender, FormClosedEventArgs e)
        {
            // Salvo los datos de configuración del usuario
            Settings.Default.mantenimientoGastoGenericoFecha1 = dtpFechaInicial.Value;
            Settings.Default.mantenimientoGastoGenericoFecha2 = dtpFechaFinal.Value;
            Settings.Default.Save();
        }




        /// <summary>
        /// Si cambia el intervalo de fecha se vuelve a cargar la lista de gastos genéricos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CambioFecha(object sender, EventArgs e)
        {
            CargaGastosGenericos();
        }



        /// <summary>
        /// Agregar un nuevo gasto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            Formulario frm = new Formulario(usuario, bd, "Agregar gasto general");

            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Agregar el gasto a la base de datos
                    Entidad.GastoGeneralSet gto = new Entidad.GastoGeneralSet();
                    gto.Fecha = frm.GetFecha;
                    gto.Concepto = frm.GetConcepto;
                    gto.Importe = frm.GetImporte;
                    gto.Pagado = frm.GetPagado;
                    gto.ProveedorId = frm.GetIdProveedor;
                    gto.TrabajadorId = frm.GetIdTrabajador;
                    ;

                    bd.GtoGenericoAgregar(gto);

                    CargaGastosGenericos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                frm.Close();
            }
        }




        /// <summary>
        /// El usuario quiere modificar un gasto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            // Tomo el gasto
            int idGasto = (int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value;
            Entidad.GastoGeneralSet gasto = new Entidad.GastoGeneralSet();
            gasto = bd.GtoGenericoLeer(idGasto);

            // Muestro el formulario
            Gastos.Genericos.Formulario frm = new Formulario(usuario, bd, "Modificar Gasto");
            frm.SetFecha = gasto.Fecha;
            frm.SetConcepto = gasto.Concepto;
            frm.SetImporte = gasto.Importe;
            frm.SetPagado = gasto.Pagado;
            frm.SetIdProveedor = gasto.ProveedorId;
            frm.SetIdTrabajador = gasto.TrabajadorId;
            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Guardar modificaciones
                    gasto.Fecha = frm.GetFecha;
                    gasto.Concepto = frm.GetConcepto;
                    gasto.Importe = frm.GetImporte;
                    gasto.Pagado = frm.GetPagado;
                    gasto.ProveedorId = frm.GetIdProveedor;
                    gasto.TrabajadorId = frm.GetIdTrabajador;

                    modelo.SaveChanges();
                    CargaGastosGenericos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                frm.Close();
            }
        }



        /// <summary>
        /// Borrar el gasto seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            // Tomo el gasto
            int idGasto = (int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value;
            Entidad.GastoGeneralSet gasto = new Entidad.GastoGeneralSet();
            gasto = bd.GtoGenericoLeer(idGasto);

            // Muestro mensaje al usuario y espero confirmación para borrado
            string msj = "¿Desea borrar el siguiente gasto?\n\n" +
                "Fecha: " + gasto.Fecha.ToString("d") +
                "\nConcepto: " + gasto.Concepto +
                "\nImporte: " + gasto.Importe;

            if (MessageBox.Show(msj, "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bd.GtoGenericoBorrar(gasto);
                CargaGastosGenericos();
            }
        }
    }
}
