using ProductCatalog.Enum;
using System;

namespace ProductCatalog.Models
{
    public class Sku
    {
        public string Id { get; set; }
        public string Ean { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }
        public string Description { get; set; }
        public StateSku State { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
