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
    
    public partial class tbListadoPrecioDetalle
    {
        public int lispd_Id { get; set; }
        public int listp_Id { get; set; }
        public string prod_Codigo { get; set; }
        public decimal lispd_PrecioMayorista { get; set; }
        public decimal lispd_PrecioMinorista { get; set; }
        public Nullable<decimal> lispd_DescCaja { get; set; }
        public Nullable<decimal> lispd_DescGerente { get; set; }
        public int lispd_UsuarioCrea { get; set; }
        public System.DateTime lispd_FechaCrea { get; set; }
        public Nullable<int> lispd_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> lispd_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbProducto tbProducto { get; set; }
        public virtual tbListaPrecio tbListaPrecio { get; set; }
    }
}