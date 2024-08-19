using IqbolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IqbolApp.Services
{
    public interface IProductService
    {
        int AddProduct(Product product);
        void DeleteProduct(int id);
        int UpdateProduct(Product product);
        List<Product> GetAllProducts();
        Product GetById(int id);
    }
}
