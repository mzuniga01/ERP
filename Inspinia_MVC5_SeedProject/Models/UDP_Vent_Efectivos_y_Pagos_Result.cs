//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models
{
    using System;
    
    public partial class UDP_Vent_Efectivos_y_Pagos_Result
    {
        public short cja_Id { get; set; }
        public Nullable<decimal> Efectivo_Inicial { get; set; }
        public Nullable<decimal> Efectivo_Recibido { get; set; }
        public Nullable<decimal> Efectivo_Entregado { get; set; }
        public Nullable<decimal> Efectivo_Pagos { get; set; }
        public Nullable<decimal> SUPER_TOTAL_EFECTIVO { get; set; }
    }
}