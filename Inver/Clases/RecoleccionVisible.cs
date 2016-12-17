using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inver.Clases
{
    public class RecoleccionVisible
    {
        public Int32 Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Clasificacion { get; set; }
        public int Bultos { get; set; }
        public int Kilos { get; set; }
        public decimal precio { get; set; }
        public string comercializadora { get; set; }
       
        public RecoleccionVisible (Int32 Id, DateTime Fecha, string Clasificacion, int bultos, int kilos, decimal precio, string comercializadora)
        {
            this.Id = Id;
            this.Fecha = Fecha;
            this.Clasificacion = Clasificacion;
            this.Bultos = bultos;
            this.Kilos = kilos;
            this.precio = precio;
            this.comercializadora = comercializadora;
        }
    }
}
