using ProductCatalog.Models;
using ProductCatalog.Dto;
using Microsoft.EntityFrameworkCore;

namespace ProductCatalog.Repositories
{
    public class ProductRepository
    {
        private readonly ProductsDataContext _context;

        public ProductRepository(ProductsDataContext context)
        {
            _context = context;
        }

        public Product Get(string id)
        {
            return _context.Product.Find(id);
        }

        public void Create(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();
        }

        public void Save(Product product)
        {
            _context.Entry<Product>(product).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Product product)
        {
            _context.Product.Remove(product);
            _context.SaveChanges();
        }
    }
}
