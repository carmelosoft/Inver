using System;
using System.Collections.Generic;
using System.Linq;
using Inver.Entidad;

namespace Inver
{
    public class BD
    {
        Entidad.inverEntities m = new inverEntities();
        
        private Entidad.inverEntities modelo;



        public void GuardarModificaciones()
        {
            modelo.SaveChanges();
        }


        #region =========================== ( TRATAMIENTOS ) =====================================



        /// <summary>
        /// Borra el tratamiento indicado.
        /// </summary>
        /// <param name="tratamiento"></param>
        public void TratamientosBorrar (Entidad.TratamientoSet tratamiento)
        {
            modelo.TratamientoSet.Remove(tratamiento);
            modelo.SaveChanges();
        }


        /// <summary>
        /// Retorna el tratamiento indicado
        /// </summary>
        /// <param name="idTratamiento"></param>
        /// <returns></returns>
        public Entidad.TratamientoSet TratamientosLee (int idTratamiento)
        {
            return modelo.TratamientoSet.First(t => t.Id == idTratamiento);
        }





        /// <summary>
        /// Agregar un nuevo tratamiento
        /// </summary>
        /// <param name="nuevoTratamiento"></param>
        public void TratamientosAgregar (Entidad.TratamientoSet nuevoTratamiento)
        {
            modelo.TratamientoSet.Add(nuevoTratamiento);
            modelo.SaveChanges();
        }



        /// <summary>
        /// Lista los tratamientos de la siembra indicada
        /// </summary>
        /// <param name="siembra"></param>
        /// <returns></returns>
        public List<Entidad.TratamientoSet> TratamientosListar (Entidad.SiembraSet siembra)
        {
            return modelo.TratamientoSet.Where(t => t.SiembraId == siembra.Id).ToList();
        }
        #endregion

        #region ============================== (TRABAJADORES)====================================



        /// <summary>
        /// Borra el trabajador indicado
        /// </summary>
        /// <param name="idTrabajador"></param>
        public void TrabajadoresBorrar (int idTrabajador)
        {
            Entidad.TrabajadorSet trabajador = new TrabajadorSet();
            trabajador = modelo.TrabajadorSet.First(t => t.Id == idTrabajador);
            modelo.TrabajadorSet.Remove(trabajador);
        }



        /// <summary>
        /// Modifica el nombre del trabajador.
        /// </summary>
        /// <param name="trabajador"></param>
        /// <param name="nuevoNombre"></param>
        public void TrabajadoresModificar (Entidad.TrabajadorSet trabajador, string nuevoNombre)
        {
            trabajador.Nombre = nuevoNombre;
            modelo.SaveChanges();
        }




        /// <summary>
        /// Devuelve el nombre del trabajador
        /// </summary>
        /// <param name="idTrabajador"></param>
        /// <returns></returns>
        public string TrabajadoresGetNombre(int idTrabajador)
        {
            return modelo.TrabajadorSet.FirstOrDefault(t => t.Id == idTrabajador).Nombre;
        }




        /// <summary>
        /// Devuelve el trabajador 
        /// </summary>
        /// <param name="idTrabajador"></param>
        /// <returns></returns>
        public Entidad.TrabajadorSet TrabajadoresLee (int idTrabajador)
        {
            return modelo.TrabajadorSet.FirstOrDefault(t => t.Id == idTrabajador);
        }


        /// <summary>
        /// Agrega un nuevo trabajador
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="nuevoTrabajador"></param>
        public void TrabajadoresAgregar (Entidad.UsuarioSet usuario, Entidad.TrabajadorSet nuevoTrabajador)
        {
            usuario.TrabajadorSet.Add(nuevoTrabajador);
            modelo.SaveChanges();
        }



        /// <summary>
        /// Devuelve la colección de trabajadores que tiene el usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public List<Entidad.TrabajadorSet> TrabajadoresListar(Entidad.UsuarioSet usuario)
        {
            return usuario.TrabajadorSet.ToList();
        }






        /// <summary>
        /// Devuelve el nombre del trabajador.
        /// 
        /// </summary>
        /// <param name="IdTrabajador"></param>
        /// <returns></returns>
        public string TrabajadoresNombreTrabajador (int IdTrabajador)
        {
            return modelo.TrabajadorSet.FirstOrDefault(t => t.Id == IdTrabajador).Nombre;
        }
        #endregion

        #region ============================ ( CONSTRUCTORES ) =======================================
        /// <summary>
        /// Constructor
        /// </summary>
        public BD ( Entidad.inverEntities modeloEF)
        {
            this.modelo = modeloEF;
        }

        #endregion

        #region =========================== ( GASTOS GENERICOS ) =======================================

        
        public void GtoGenericoBorrar (Entidad.GastoGeneralSet gasto)
        {
            modelo.GastoGeneralSet.Remove(gasto);
            modelo.SaveChanges();
        }

        /// <summary>
        /// Agrega el gasto
        /// </summary>
        /// <param name="gastoNuevo"></param>
        public void GtoGenericoAgregar (Entidad.GastoGeneralSet gastoNuevo)
        {
            modelo.GastoGeneralSet.Add(gastoNuevo);
            modelo.SaveChanges();
        }



        /// <summary>
        /// Devuelve el gasto indicado por su id
        /// </summary>
        /// <param name="idGasto"></param>
        /// <returns></returns>
        public Entidad.GastoGeneralSet GtoGenericoLeer (int idGasto)
        {
            return modelo.GastoGeneralSet.First(g => g.Id == idGasto);
        }

        /// <summary>
        /// Devuelve los gastos generales que tenga el usuario en el intervalo de fechas dado.
        /// 
        /// · Recorro cada proveedor buscando sus gastos y verificando que están dentro de intervalo.
        /// 
        /// </summary>
        /// <param name="fecha1"></param>
        /// <param name="fecha2"></param>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public List<Clases.GastoGeneral> GtoGenericoListar (DateTime fecha1, DateTime fecha2, Entidad.UsuarioSet usuario, ref Clases.TotalGastos totales)
        {
            decimal sumaPagado = 0, sumaPendiente = 0;

            List<Clases.GastoGeneral> gastos = new List<Clases.GastoGeneral>();

            // Tomo los proveedores que tiene el usuario para posteriormente buscar gastos de cada uno
            List<Entidad.ProveedorSet> proveedores = new List<ProveedorSet>();
            proveedores = usuario.ProveedorSet.ToList();

            // Ahora recorro la colección de proveedores para buscar gastos dentro de cada uno de ellos
            foreach (Entidad.ProveedorSet proveedor in proveedores)
            {
                // Busco los gastos que tenga este proveedor en el intervalo indicado
                List<Entidad.GastoGeneralSet> gastoGeneralesProveedor = new List<GastoGeneralSet>();
                gastoGeneralesProveedor = proveedor.GastoGeneralSet.Where (gg=>gg.Fecha >= fecha1 && gg.Fecha<= fecha2).ToList(); // Aquí tengo los gastos generales de éste proveedor en intervalo fechas

                // Recorro la colección de gastos generales del proveedor construyendo la lista resultado
                foreach (Entidad.GastoGeneralSet g in gastoGeneralesProveedor)
                {
                    Clases.GastoGeneral gNuevo = new Clases.GastoGeneral( 
                                                g.Id,
                                                g.Fecha,
                                                g.Concepto,
                                                g.Importe,
                                                g.Pagado,
                                                g.ProveedorId,
                                                g.TrabajadorId,
                                                ProveedoresNombreProveedor(g.ProveedorId),
                                                TrabajadoresNombreTrabajador(g.TrabajadorId));

                    gastos.Add(gNuevo);       
                    
                    // para los totales
                    if (g.Pagado)
                    {
                        // Es un gasto pagado
                        sumaPagado += g.Importe;
                    } else
                    {
                        // es un gto. pendiente de pago
                        sumaPendiente += g.Importe;
                    }
                }
            }

            totales.Pagados = sumaPagado;
            totales.Pendiente = sumaPendiente;
            totales.Suma = sumaPendiente + sumaPagado;

            return gastos;
        }
        #endregion

        #region ==================================== ( SIEMBRAS ) ============================================



        /// <summary>
        /// Devuelve una colección de siembras
        /// </summary>
        /// <param name="todas"></param>
        /// <param name="activas"></param>
        /// <param name="cerradas"></param>
        /// <returns></returns>
        public List<Entidad.SiembraSet> SiembrasListar(bool todas, bool activas, bool cerradas)
        {
            
            if (activas) {
                // Activas
                return modelo.SiembraSet.Where(s => s.Activa == true).ToList();
            } else  if (todas)
            {
                // Todas
                return modelo.SiembraSet.ToList();
            } else
            {
                // Cerradas
                return modelo.SiembraSet.Where(s => s.Activa == false).ToList();
            }
        }

        



        /// <summary>
        /// Insertar una siembra
        /// </summary>
        /// <param name="siembra"></param>
        /// <returns></returns>
        public bool SiembraInsertar(SiembraSet siembra)
        {
            bool resultado = true;

            modelo.SiembraSet.Add(siembra);
            modelo.SaveChanges();

            return resultado;
        }



        /// <summary>
        /// Lee una siembra
        /// </summary>
        /// <param name="idSiembra"></param>
        /// <returns></returns>
        public SiembraSet SiembrasLeeSiembra(int idSiembra)
        {
            return (modelo.SiembraSet.First(s => s.Id == idSiembra));
        }



        /// <summary>
        /// Modificar la siembra
        /// </summary>
        /// <param name="getSiembra"></param>
        /// <returns></returns>
        public bool SiembrasModificar(int idSiembra, SiembraSet siembraNueva)
        {
            bool resultado = true;

            Entidad.SiembraSet siembraOld = new SiembraSet();
            siembraOld = modelo.SiembraSet.First(s => s.Id == idSiembra); // La antigua
            siembraOld.Fecha = siembraNueva.Fecha;
            siembraOld.Cultivo = siembraNueva.Cultivo;
            siembraOld.Plantas = siembraNueva.Plantas;
            siembraOld.Superficie = siembraNueva.Superficie;
            modelo.SaveChanges();

            return resultado;
        }



        /// <summary>
        /// Borrar la siembra
        /// </summary>
        /// <param name="siembra"></param>
        public bool SiembrasBorrar(SiembraSet siembra)
        {
            bool resultado = true;
            try
            {
                modelo.SiembraSet.Remove(siembra);
                modelo.SaveChanges();
            } catch
            {
                resultado = false;            
            }

            return resultado;
        }

        #endregion

        #region ==================================== ( RECOLECCIONES ) =====================================



        public void RecoleccionesAgregar (Entidad.SiembraSet siembra, Entidad.RecoleccionSet recoleccion)
        {                        
            siembra.RecoleccionSet.Add(recoleccion);
            modelo.SaveChanges();
        }





        /// <summary>
        /// Borra la recolección indicada
        /// </summary>
        /// <param name="recoleccion"></param>
        public void RecoleccionesBorrar (Entidad.RecoleccionSet recoleccion)
        {
            modelo.RecoleccionSet.Remove(recoleccion);
            modelo.SaveChanges();
        }
        


        /// <summary>
        /// Devuelve la recolección indicada
        /// </summary>
        /// <param name="idRecoleccion"></param>
        /// <returns></returns>
        public Entidad.RecoleccionSet RecoleccionesLeer (Int32 idRecoleccion)
        {
            
            return  modelo.RecoleccionSet.First(x => x.Id == idRecoleccion);
        }






        /// <summary>
        /// Actualiza la recoleccion
        /// </summary>
        /// <param name="recoleccion"></param>
        public void RecoleccionesModificar ( Entidad.RecoleccionSet recoleccion)
        {
            Entidad.RecoleccionSet rOld = new RecoleccionSet();
            rOld = modelo.RecoleccionSet.First(r => r.Id == recoleccion.Id); // Tomo la recolección antigua
            modelo.RecoleccionSet.Remove(rOld); // Borro la vieja 
            modelo.RecoleccionSet.Add(recoleccion); // agrego la nueva
            modelo.SaveChanges();
            
        }



        /// <summary>
        /// Devuelve una colección de las recolecciones según filtro.
        /// 
        /// · Calcula totales de Kilos
        /// </summary>
        public List<Clases.RecoleccionVisible> RecoleccionesListar ( Entidad.SiembraSet siembra, bool todas, bool cobradas, bool pendientes,
                                out Int32 TKilos, out Int32 TKilosCobrados, out Int32 TKilosImpagados,
                                out decimal TCobrado, out decimal precioMedio, out decimal estimadoPorCobrar,
                                out decimal kilosMetro)
        {

            List<Clases.RecoleccionVisible> vista = new List<Clases.RecoleccionVisible>();

            TKilos = 0; TKilosCobrados = 0; TKilosImpagados = 0; TCobrado = 0; precioMedio = 0; estimadoPorCobrar = 0; kilosMetro = 0 ;


            // Recorro la recolecciones que tiene esta siembra
            foreach (Entidad.RecoleccionSet recoleccion in siembra.RecoleccionSet)
            {
                // Aplico filtros
                if (todas) // Ver todas recolecciones
                {
                    Clases.RecoleccionVisible nuevaRec = new Clases.RecoleccionVisible(
                              recoleccion.Id, recoleccion.Fecha, recoleccion.ClasificacionSet.Clase,
                              recoleccion.Bultos, recoleccion.Kilos, recoleccion.Precio, recoleccion.ComercializadoraSet.Nombre);

                    vista.Add(nuevaRec);
                    TKilos += recoleccion.Kilos;
                    if (recoleccion.Cobrado)
                    {
                        TCobrado += recoleccion.Kilos * recoleccion.Precio;
                        TKilosCobrados += recoleccion.Kilos;
                    } else
                    {
                        TKilosImpagados += recoleccion.Kilos;
                    }
                     

                } else if (cobradas)
                {
                    // Solo las cobradas
                    if (recoleccion.Cobrado)
                    {
                        Clases.RecoleccionVisible nuevaRec = new Clases.RecoleccionVisible(
                              recoleccion.Id, recoleccion.Fecha, recoleccion.ClasificacionSet.Clase,
                              recoleccion.Bultos, recoleccion.Kilos, recoleccion.Precio, recoleccion.ComercializadoraSet.Nombre);

                        vista.Add(nuevaRec);
                        TKilosCobrados += recoleccion.Kilos;
                        TCobrado += recoleccion.Kilos * recoleccion.Precio;
                    }
                }
                else
                {
                    // Las no cobradas
                    if (!recoleccion.Cobrado)
                    {
                        Clases.RecoleccionVisible nuevaRec = new Clases.RecoleccionVisible(
                              recoleccion.Id, recoleccion.Fecha, recoleccion.ClasificacionSet.Clase,
                              recoleccion.Bultos, recoleccion.Kilos, recoleccion.Precio, recoleccion.ComercializadoraSet.Nombre);

                        vista.Add(nuevaRec);
                        TKilosImpagados += recoleccion.Kilos;

                    }

                } // if 

            } // foreach 


            // Calculo el precio medio
            if (TKilosCobrados > 0)
            {
                precioMedio = TCobrado / TKilosCobrados;
            } else
            {
                precioMedio = 0;
            }
            estimadoPorCobrar = TKilosImpagados * precioMedio;
            kilosMetro = TKilos / siembra.Superficie;


            return vista;
          

        }



        #endregion

        #region ================================== ( COMERCIALIZADORAS ) ===============================




        public void ComercializadorasBorrar (Int32 comercializadora)
        {
            Entidad.ComercializadoraSet co = new ComercializadoraSet();
            co = modelo.ComercializadoraSet.First(c => c.Id == comercializadora);
            modelo.ComercializadoraSet.Remove(co);
            modelo.SaveChanges();
        }





        /// <summary>
        /// Modificar a la comercializadora indicada su nombre
        /// </summary>
        /// <param name="idComercializadora"></param>
        /// <param name="nombreComercializadora"></param>
        public void ComercializadorasModificar(Int32 idComercializadora, string nombreComercializadora, short comision)
        {
            Entidad.ComercializadoraSet comercializadora = new ComercializadoraSet();
            comercializadora = modelo.ComercializadoraSet.First(c => c.Id == idComercializadora);
            comercializadora.Nombre = nombreComercializadora;
            comercializadora.Comision = comision;
            modelo.SaveChanges();
        }



        public Int32 ComercializadorasInserta (Entidad.ComercializadoraSet comercializadora)
        {
            modelo.ComercializadoraSet.Add(comercializadora);
            modelo.SaveChanges();

            return comercializadora.Id;
        }


        /// <summary>
        /// Devuelve una colección de las comercializadoras asignadas a la siembra indicada como parámetro.
        /// </summary>
        /// <param name="idSiembra"></param>
        /// <returns></returns>
        public List<Entidad.ComercializadoraSet> ComercializadorasListar ( int idSiembra)
        {
            return modelo.ComercializadoraSet.Where(c => c.SiembraId == idSiembra).ToList();
        }





        /// <summary>
        /// Devuelve la entidad Comercializadora indicada por su Id
        /// </summary>
        /// <param name="idComercializadora"></param>
        /// <returns></returns>
        public Entidad.ComercializadoraSet ComercializadorasLee ( int idComercializadora)
        {
            return modelo.ComercializadoraSet.First(c => c.Id == idComercializadora);
        }


        #endregion
        
        #region ====================================== ( CLASIFICACIONES ) ==========================================

        


        public void ClasificacionesBorrar (Int32 idClasificacion)
        {
            Entidad.ClasificacionSet clasificacion = new ClasificacionSet();
            clasificacion = modelo.ClasificacionSet.First(c => c.Id == idClasificacion);
            modelo.ClasificacionSet.Remove(clasificacion);
            modelo.SaveChanges();
        }






        /// <summary>
        /// Modifica la clasificación indicada
        /// </summary>
        /// <param name="clasificacionOld"></param>
        /// <param name="clasificacion"></param>
        public void ClasificacionesModificar (Entidad.ClasificacionSet clasificacionOld, Entidad.ClasificacionSet clasificacion)
        {
            Entidad.ClasificacionSet cl = new ClasificacionSet();
            cl = modelo.ClasificacionSet.First(c => c.Id == clasificacionOld.Id);

            cl.Clase = clasificacion.Clase;
            
            modelo.SaveChanges();
        }


        /// <summary>
        /// Devuelve una colección con las clasificaciones que hay en la siembra indicada
        /// </summary>
        /// <param name="idSiembra"></param>
        /// <returns></returns>
        public List<Entidad.ClasificacionSet> ClasificacionesListar ( int idSiembra)
        {
            return modelo.ClasificacionSet.Where(c => c.SiembraId == idSiembra).ToList();

            //return modelo.ClasificacionSet.Where(c => c.SiembraId == idSiembra).ToList();

            //List<Entidad.Clasificacion> c = new List<Clasificacion>();
            //return c;
        }


        public Int32 ClasificacionesInserta (Entidad.ClasificacionSet clasificacion)
        {
            modelo.ClasificacionSet.Add(clasificacion);
            modelo.SaveChanges();
            return clasificacion.Id;
        }


        /// <summary>
        /// Devuelve una entidad indicada
        /// </summary>
        /// <param name="idClasificacion"></param>
        /// <returns></returns>
        public Entidad.ClasificacionSet ClasificacionesLee (int idClasificacion)
        {
            return modelo.ClasificacionSet.First(c => c.Id == idClasificacion);
        }


        #endregion

        #region =============================== ( USUARIOS ) ========================================




        /// <summary>
        /// Devuelve el usuario indicado.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public Entidad.UsuarioSet UsuariosLeeUsuario(string nombre)
        {
            return modelo.UsuarioSet.First(u => u.Nombre == nombre);
        }




        /// <summary>
        /// Determina si el usuario y clave tienen acceso
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="clave"></param>
        /// <param name="msjSalida"></param>
        /// <returns></returns>
        public bool UsuariosTieneAcceso (string nombre, string clave, out string msjSalida)
        {
            bool tieneAcceso = true;
            msjSalida = "Tiene acceso al sistema";

            Entidad.UsuarioSet usuario = new UsuarioSet();
            usuario = modelo.UsuarioSet.FirstOrDefault(u => u.Nombre == nombre);
            if (usuario != null)
            {
                // Existe.
                if (usuario.Clave == clave)
                {
                    tieneAcceso = true;
                }
                else
                {
                    tieneAcceso = false;
                    msjSalida = "Combinación de usuario y clave incorrectas";
                }
            } else
            {
                // No existe
                msjSalida = "El usuario indicado no existe, si no tiene un usuario y clave solicite una";
                tieneAcceso = false;
            }




            return tieneAcceso;
        }
        #endregion

        #region ======================================= (PROVEEDORES) =====================================





        /// <summary>
        /// Borra el proveedor pasado como parámetro.
        /// </summary>
        /// <param name="proveedor"></param>
        public void ProveedoresBorrar (Entidad.ProveedorSet proveedor)
        {
            modelo.ProveedorSet.Remove(proveedor);
            modelo.SaveChanges();
        }









        /// <summary>
        /// Modificar el nombre del proveedor
        /// </summary>
        /// <param name="proveedor"></param>
        /// <param name="nuevoNombre"></param>
        public void ProveedoresModifica (Entidad.ProveedorSet proveedor, string nuevoNombre)
        {
            proveedor.Nombre = nuevoNombre;
            modelo.SaveChanges();
        }



        /// <summary>
        /// Devuelve el proveedor indicado por su Id
        /// </summary>
        /// <param name="IdProveedor"></param>
        /// <returns></returns>
        public Entidad.ProveedorSet ProveedoresLee (int IdProveedor)
        {
            return (modelo.ProveedorSet.FirstOrDefault(p => p.Id == IdProveedor));
        }



        /// <summary>
        /// Devuelve el nombre del proveedor referenciado por su ID
        /// </summary>
        /// <param name="IdProveedor"></param>
        /// <returns></returns>
        public string ProveedoresNombreProveedor (int IdProveedor)
        {
            return modelo.ProveedorSet.FirstOrDefault(p => p.Id == IdProveedor).Nombre;
        }



        /// <summary>
        /// Agregar un nuevo proveedor al usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="proveedorNuevo"></param>
        public void ProveedoresAgregar (UsuarioSet usuario, ProveedorSet proveedorNuevo)
        {
            usuario.ProveedorSet.Add(proveedorNuevo);
            modelo.SaveChanges();
        }




        /// <summary>
        /// Devuelve el listado completo de proveedores del usuario
        /// </summary>
        /// <returns></returns>
        public List<Entidad.ProveedorSet> ProveedoresListar(Entidad.UsuarioSet usuario)
        {
            return usuario.ProveedorSet.ToList();
        }




        #endregion
    }
}
