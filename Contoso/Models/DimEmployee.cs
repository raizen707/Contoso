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
    
    public partial class DimEmployee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DimEmployee()
        {
            this.DimEmployee1 = new HashSet<DimEmployee>();
        }
    
        public int EmployeeKey { get; set; }
        public Nullable<int> ParentEmployeeKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string MaritalStatus { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public Nullable<bool> SalariedFlag { get; set; }
        public string Gender { get; set; }
        public Nullable<byte> PayFrequency { get; set; }
        public Nullable<decimal> BaseRate { get; set; }
        public Nullable<short> VacationHours { get; set; }
        public bool CurrentFlag { get; set; }
        public bool SalesPersonFlag { get; set; }
        public string DepartmentName { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Status { get; set; }
        public Nullable<int> ETLLoadID { get; set; }
        public Nullable<System.DateTime> LoadDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DimEmployee> DimEmployee1 { get; set; }
        public virtual DimEmployee DimEmployee2 { get; set; }
    }
}
