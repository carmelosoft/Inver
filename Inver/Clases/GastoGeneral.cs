using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inver.Clases
{
    public class GastoGeneral
    {
        private int id;
        private DateTime fecha;
        private string concepto;
        private decimal importe;
        private bool pagado;
        private int proveedorId;
        private int trabajadorId;
        private string proveedor;
        private string trabajador;

        public GastoGeneral(int id, DateTime fecha, string concepto, decimal importe, bool pagado, int proveedorId, int trabajadorId, string proveedor, string trabajador)
        {
            this.id = id;
            this.fecha = fecha;
            this.concepto = concepto;
            this.importe = importe;
            this.pagado = pagado;
            this.proveedorId = proveedorId;
            this.trabajadorId = trabajadorId;
            this.proveedor = proveedor;
            this.trabajador = trabajador;
        }



        /// <summary>
        /// Nombre completo del trabajador que realiza el gasto
        /// </summary>
        public string Trabajador
        {
            get { return trabajador; }
            set { trabajador = value; }
        }


        /// <summary>
        /// NOmbre del proveedor
        /// </summary>
        public string Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }



        /// <summary>
        /// Identificador del trabajador que ha realizado el gasto
        /// </summary>
        public int TrabajadorId
        {
            get { return trabajadorId; }
            set { trabajadorId = value; }
        }

        /// <summary>
        /// Identificador del proveedor
        /// </summary>
        public int ProveedorId
        {
            get
            {
                return proveedorId;
            }
            set
            {
                proveedorId = value;
            }
        }


        /// <summary>
        /// Identificador del gasto
        /// </summary>
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }




        /// <summary>
        /// La fecha del gasto
        /// </summary>
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


        /// <summary>
        /// Concepto del gasto o descripción
        /// </summary>
        public string Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }




        /// <summary>
        /// El coste de este gasto
        /// </summary>
        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }



        /// <summary>
        /// Determina si este gasto está pagado ó pendiente de pago
        /// </summary>
        public bool Pagado
        {
            get
            {
                return pagado;
            } set
            {
                pagado = value;
            }
        }
    }



  

   
}
