//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaConexion3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        public int ID_Venta { get; set; }
        public System.DateTime Fecha_venta { get; set; }
        public Nullable<int> ID_Cotizacion { get; set; }
        public Nullable<int> ID_Usuario { get; set; }
    
        public virtual Cotizacion Cotizacion { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
