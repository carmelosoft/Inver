using System;
using System.Windows.Forms;

namespace Inver
{
    public partial class Principal : Form
    {

        Entidad.inverEntities modelo;
        private BD bd;
        private Entidad.UsuarioSet usuario;


        /// <summary>
        /// Constructor
        /// </summary>
        public Principal()
        {
            InitializeComponent();

            modelo = new Entidad.inverEntities();
            bd = new BD(modelo);
        }


        


        /// <summary>
        /// Al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Principal_Load(object sender, EventArgs e)
        {
            // Pido identificarse al usuario
            string nombre = null, clave = null, msjSalida = null;
            if (IdentificacionUsuario(ref nombre, ref clave))
            {
                // Verificar identificación
                if (bd.UsuariosTieneAcceso(nombre, clave, out msjSalida))
                {
                    // Si, es correcto, leo el usuario con el que trabajará la aplicación
                    usuario = bd.UsuariosLeeUsuario(nombre);
                } else
                {
                    // No tiene acceso.
                    MessageBox.Show(msjSalida,"¡¡¡Acceso no permitido!!!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    Close();
                }
            }
            else
            {
                // Ha cancelado la identificación
                MessageBox.Show("Sin un usuario y clave no puede acceder, solicite uno para tener acceso a la aplicación","¡¡¡Acceso no permitido!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            };


            CargaSiembras();
        }





        /// <summary>
        /// Muestra al usuario el formulario de login y toma los datos que inserta
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="clave"></param>
        private bool IdentificacionUsuario (ref string nombre, ref string clave)
        {
            bool respuesta;

            Login frm = new Login();
            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    respuesta = true;
                    // devuelvo las credenciales que haya indicado
                    nombre = frm.usuario;
                    clave = frm.clave;
                } else
                {
                    respuesta = false;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error en Acceso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                respuesta = false;
            } finally
            {
                frm.Close();
            }


            return respuesta;
        }




        /// <summary>
        /// Filtrar las siembras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiltrarSiembras(object sender, EventArgs e)
        {
            CargaSiembras();
        }






        /// <summary>
        /// Carga las siembras en función del filtro activo.
        /// </summary>
        private void CargaSiembras()
        {            
            dgv.DataSource = bd.SiembrasListar(rbTodas.Checked, rbActivas.Checked, rbFinalizadas.Checked);

            if (dgv.RowCount != 0)
            {
                tsbModificar.Enabled = true;
                tsbBorrarSiembra.Enabled = true;
                tsbRecolecciones.Enabled = true;
                tsbTratamientos.Enabled = true;
            } else
            {
                tsbModificar.Enabled = false;
                tsbBorrarSiembra.Enabled = false;
                tsbRecolecciones.Enabled = false;
                tsbTratamientos.Enabled = false;
            }
        }



        /// <summary>
        /// Cierra la aplicación
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Close();
        }




        /// <summary>
        /// Agregar una nueva siembra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Siembras.formulario frm = new Siembras.formulario("Crear una Siembra");

            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Guardar la nueva siembra
                    Entidad.SiembraSet siembra = new Entidad.SiembraSet();
                    siembra = frm.GetSiembra;
                    if (bd.SiembraInsertar(siembra))
                    {
                        MessageBox.Show("La siembra se ha creado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargaSiembras();
                    };
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                frm.Close();
            }
        }



        /// <summary>
        /// Modificar la siembra actualmente seleccionada en el gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            // Tomo la siembra a modificar
            Entidad.SiembraSet siembra = new Entidad.SiembraSet();
            int idSiembra = (int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value;
            siembra = bd.SiembrasLeeSiembra(idSiembra);


            // Muestro el formulario y le paso la siembra a modificar
            Siembras.formulario frm = new Siembras.formulario("Modificar Siembra", siembra);

            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (bd.SiembrasModificar(idSiembra, frm.GetSiembra))
                    {
                        MessageBox.Show("La siembra ha sido modificada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargaSiembras();
                    };
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                frm.Close();
            }

        }




        /// <summary>
        /// Borrar la siembra seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBorrarSiembra_Click(object sender, EventArgs e)
        {
            Entidad.SiembraSet siembra = new Entidad.SiembraSet();
            int idSiembra = (int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value;
            siembra = bd.SiembrasLeeSiembra(idSiembra);

            string msj = "¿Desea realmente borrar la siguiente siembra?\n\n" +
                "Fecha : " + siembra.Fecha.ToShortDateString() + "\n" +
                "Cultivo : " + siembra.Cultivo + "\n" +
                "Superficie : " + siembra.Superficie.ToString() + "\n" +
                "Plantas : " + siembra.Plantas.ToString();

            if (MessageBox.Show (msj,"¡Atención!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bd.SiembrasBorrar(siembra);
                CargaSiembras();
            }

        }




        /// <summary>
        /// Mantenimiento de recolecciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbRecolecciones_Click(object sender, EventArgs e)
        {
            // Tomo la siembra seleccionada
            Entidad.SiembraSet siembra = new Entidad.SiembraSet();
            siembra = bd.SiembrasLeeSiembra((int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value);

            // Muestro el formulario para el mantenimiento de las recolecciones de la siembra indicada
            Recolecciones.Mantenimiento frm = new Recolecciones.Mantenimiento( modelo, bd, siembra);

            try
            {
                frm.ShowDialog();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                frm.Close();
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            test.test1 frm = new test.test1(modelo, bd);
            try
            {
                frm.ShowDialog();
            } catch (Exception ex)
            {
                MessageBox.Show
                    (ex.Message.ToString());
            } finally
            {
                frm.Close();
            }
        }



        /// <summary>
        /// Cerrar aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }



        /// <summary>
        /// Mantenimiento fichero de clasificación géneros.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clasificacionesDeGénerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clasificaciones.Mantenimiento frm = new Clasificaciones.Mantenimiento(modelo,bd);


            try
            {
                frm.ShowDialog();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                frm.Close();
            }
        }



        /// <summary>
        /// Mantenimiento de comercializadoras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comercializadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comercializadoras.Mantenimiento frm = new Comercializadoras.Mantenimiento("Mantenimiento de comercializadoras", modelo, bd);

            try
            {
                frm.ShowDialog();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                     
            } finally
            {
                frm.Close();
            }
        }





        /// <summary>
        /// Anotar gastos genéricos a todas las siembras 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gastosGenéricosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gastos.Genericos.Mantenimiento frm = new Gastos.Genericos.Mantenimiento(modelo, bd, usuario);

            try
            {
                frm.ShowDialog();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                frm.Close();
            }
        }




        /// <summary>
        /// Mantenimiento de proveedores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores.Mantenimiento frm = new Proveedores.Mantenimiento(modelo, bd, usuario);

            try
            {
                frm.ShowDialog();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } finally
            {
                frm.Close();
            }
        }





        /// <summary>
        /// Mantenimiento de trabajadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MantenimientoTrabajadores(object sender, EventArgs e)
        {
            
            Trabajadores.Mantenimiento frm = new Trabajadores.Mantenimiento(usuario,bd);

            try
            {
                frm.ShowDialog();
            } catch 
            (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                frm.Close();
            }
        }



        /// <summary>
        /// Mantenimiento de tratamientos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbTratamientos_Click(object sender, EventArgs e)
        {
            // Tomo la siembra de la que queremos acceder al mantenimiento de tratamientos
            Entidad.SiembraSet siembra = new Entidad.SiembraSet();
            int idSiembra = (int)dgv["ColumId", dgv.CurrentCell.RowIndex].Value;
            siembra = bd.SiembrasLeeSiembra(idSiembra);

            Tratamientos.Mantenimiento frm = new Tratamientos.Mantenimiento(usuario, siembra, bd);

            try
            {
                frm.ShowDialog();
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
