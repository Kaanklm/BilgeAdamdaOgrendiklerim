using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Products
{
    public interface IProductService
    {

        Task<bool> AddProduct(Product product);
        Task<bool> UpdateProduct(Product product    );
        Task<List<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<bool> DeleteProduct(int id);

    }
}
