//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contoso.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DimProductCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DimProductCategory()
        {
            this.DimProductSubcategories = new HashSet<DimProductSubcategory>();
            this.FactStrategyPlans = new HashSet<FactStrategyPlan>();
        }
    
        public int ProductCategoryKey { get; set; }
        public string ProductCategoryLabel { get; set; }
        public string ProductCategoryName { get; set; }
        public string ProductCategoryDescription { get; set; }
        public Nullable<int> ETLLoadID { get; set; }
        public Nullable<System.DateTime> LoadDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DimProductSubcategory> DimProductSubcategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactStrategyPlan> FactStrategyPlans { get; set; }
    }
}