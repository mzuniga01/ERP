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
    
    public partial class UDP_Inv_tbInventarioFisico_ReporteFaltantes_Result
    {
        public System.DateTime invf_FechaInventario { get; set; }
        public string invf_Descripcion { get; set; }
        public string bod_Nombre { get; set; }
        public string invf_ResponsableBodega { get; set; }
        public string prod_Codigo { get; set; }
        public string prod_Descripcion { get; set; }
        public string prod_CodigoBarras { get; set; }
        public string prod_Marca { get; set; }
        public string prod_Talla { get; set; }
        public string uni_Descripcion { get; set; }
        public decimal invfd_Cantidad { get; set; }
        public decimal invfd_CantidadSistema { get; set; }
        public Nullable<decimal> Sobrante_Faltante { get; set; }
    }
}
