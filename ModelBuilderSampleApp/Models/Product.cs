using System;

namespace ModelBuilderSampleApp.Models
{
    /// This file is auto-generated. Do not make manual changes to this file
    /// Product entity
    public class Product
    {
        public int ProductId { get; set; } 

        public string ProductName { get; set; } 

        public string QuantityPerUnit { get; set; } 

        public decimal? UnitPrice { get; set; } 

        public Int16? UnitsInStock { get; set; } 

        public Int16? UnitsOnOrder { get; set; } 

        public Int16? ReorderLevel { get; set; } 

        public bool Discontinued { get; set; } 
    }
}
