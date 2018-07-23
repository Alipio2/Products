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

        internal Product Get(int id)
        {
            return _context.Product.Find(id);
        }

        internal void Create(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();
        }

        internal void Save(Product product)
        {
            _context.Entry<Product>(product).State = EntityState.Modified;
            _context.SaveChanges();
        }

        internal void Delete(Product product)
        {
            _context.Product.Remove(product);
            _context.SaveChanges();
        }
    }
}
