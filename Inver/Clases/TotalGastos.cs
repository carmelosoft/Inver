using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inver.Clases
{
    public class TotalGastos
    {
        private decimal suma;
        private decimal pagados;
        private decimal pendiente;

        public TotalGastos()
        {
            this.suma = 0;
            this.pagados = 0;
            this.pendiente = 0;
        }


        public TotalGastos(decimal suma, decimal pagados, decimal pendiente)
        {
            this.suma = suma;
            this.pagados = pagados;
            this.pendiente = pendiente;
        }

        public decimal Suma
        {
            get
            {
                return suma;
            }

            set
            {
                suma = value;
            }
        }

        public decimal Pagados
        {
            get
            {
                return pagados;
            }

            set
            {
                pagados = value;
            }
        }

        public decimal Pendiente
        {
            get
            {
                return pendiente;
            }

            set
            {
                pendiente = value;
            }
        }
    }
}
