//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inver.Entidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class GastosSiembraSet
    {
        public int Id { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Concepto { get; set; }
        public decimal Importe { get; set; }
        public bool Pagado { get; set; }
        public int ProveedorId { get; set; }
        public int SiembraId { get; set; }
        public int TrabajadorId { get; set; }
    
        public virtual ProveedorSet ProveedorSet { get; set; }
        public virtual SiembraSet SiembraSet { get; set; }
        public virtual TrabajadorSet TrabajadorSet { get; set; }
    }
}
