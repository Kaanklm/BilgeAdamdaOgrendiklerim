using Application;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Products
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> productService;

        public ProductService(IRepository<Product> _productService)
        {
            productService = _productService;
        }

        public async Task<bool> AddProduct(Product product)
        {
            try
            {
                var result =await productService.Add(product);
                return result;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DeleteProduct(int id)
        {
            try
            {
                var result =await productService.Delete(id);
                return result;
            }
            catch (Exception)
            {

                return false;   
            }
        }

        public Task<List<Product>> GetAll()
        {
            return productService.GetAll();
        }

        public Task<Product> GetById(int id)
        {
            return productService.GetById(id);
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            try
            {
                var result =await productService.Update(product);
                return result;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
