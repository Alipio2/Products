using ProductCatalog.Enum;
using System;
using System.Collections.Generic;

namespace ProductCatalog.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public string SellersName { get; set; }
        public string CategoryName { get; set; }
        public StateProdutc State { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public IEnumerable<Sku> Skus { get; set; }       
        
    }
}
