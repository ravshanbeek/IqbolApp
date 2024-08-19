using IqbolApp.Data;
using IqbolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IqbolApp.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public int AddProduct(Product product)
        {
            var entity = _context.Products.Add(product);
            _context.SaveChanges();

            return entity.Entity.Id;
        }

        public void DeleteProduct(int id)
        {
            var entity = _context.Products.Where(p => p.Id == id).FirstOrDefault();

            if(entity == null)
            {
                throw new Exception("Maxsulot topilmadi");
            }

            _context.Products.Remove(entity);

            _context.SaveChanges();
        }

        public int UpdateProduct(Product product)
        {
            var entity = _context.Products.Where(p => p.Id == product.Id).FirstOrDefault();

            if (entity == null)
            {
                throw new Exception("Maxsulot topilmadi");
            }

            entity.Name = product.Name;
            entity.Amount = product.Amount;
            entity.Count = product.Count;
            entity.ActualAmount = product.ActualAmount;

            var changed = _context.SaveChanges();

            return changed;
        }

        public List<Product> GetAllProducts()
        {
            var list = _context.Products.ToList();
            return list;
        }

        public Product GetById(int id)
        {
            var entity = _context.Products.Where(x => x.Id == id).FirstOrDefault();

            if (entity == null)
            {
                throw new Exception("Maxsulot topilmadi");
            }

            return entity;
        }

    }
}
