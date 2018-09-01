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
    
    public partial class FactSale
    {
        public int SalesKey { get; set; }
        public System.DateTime DateKey { get; set; }
        public int channelKey { get; set; }
        public int StoreKey { get; set; }
        public int ProductKey { get; set; }
        public int PromotionKey { get; set; }
        public int CurrencyKey { get; set; }
        public decimal UnitCost { get; set; }
        public decimal UnitPrice { get; set; }
        public int SalesQuantity { get; set; }
        public int ReturnQuantity { get; set; }
        public Nullable<decimal> ReturnAmount { get; set; }
        public Nullable<int> DiscountQuantity { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public decimal TotalCost { get; set; }
        public decimal SalesAmount { get; set; }
        public Nullable<int> ETLLoadID { get; set; }
        public Nullable<System.DateTime> LoadDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual DimChannel DimChannel { get; set; }
        public virtual DimCurrency DimCurrency { get; set; }
        public virtual DimDate DimDate { get; set; }
        public virtual DimProduct DimProduct { get; set; }
        public virtual DimPromotion DimPromotion { get; set; }
        public virtual DimStore DimStore { get; set; }
    }
}