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
    using System.Collections.Generic;
    
    public partial class UDV_Vent_ListadodePrecios
    {
        public int listp_Id { get; set; }
        public string listp_Nombre { get; set; }
        public Nullable<System.DateTime> listp_FechaInicioVigencia { get; set; }
        public Nullable<System.DateTime> listp_FechaFinalVigencia { get; set; }
        public Nullable<short> listp_Prioridad { get; set; }
        public string prod_CodigoBarras { get; set; }
        public string prod_Descripcion { get; set; }
        public string prod_Marca { get; set; }
        public string prod_Modelo { get; set; }
        public string prod_Talla { get; set; }
        public int uni_Id { get; set; }
        public decimal lispd_PrecioMayorista { get; set; }
        public decimal lispd_PrecioMinorista { get; set; }
    }
}