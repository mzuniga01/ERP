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
    
    public partial class tbRol
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbRol()
        {
            this.tbAccesoRol = new HashSet<tbAccesoRol>();
            this.tbRolesUsuario = new HashSet<tbRolesUsuario>();
            this.tbParametro = new HashSet<tbParametro>();
            this.tbParametro1 = new HashSet<tbParametro>();
            this.tbParametro2 = new HashSet<tbParametro>();
            this.tbParametro3 = new HashSet<tbParametro>();
            this.tbParametro4 = new HashSet<tbParametro>();
        }
    
        public int rol_Id { get; set; }
        public string rol_Descripcion { get; set; }
        public int rol_UsuarioCrea { get; set; }
        public System.DateTime rol_FechaCrea { get; set; }
        public Nullable<int> rol_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> rol_FechaModifica { get; set; }
        public Nullable<bool> rol_Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAccesoRol> tbAccesoRol { get; set; }
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRolesUsuario> tbRolesUsuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbParametro> tbParametro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbParametro> tbParametro1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbParametro> tbParametro2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbParametro> tbParametro3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbParametro> tbParametro4 { get; set; }
    }
}