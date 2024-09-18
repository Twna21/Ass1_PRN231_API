using BussinessObject;
using DataAccess;
using DataAccess.DTO;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepository : IProductRepository
    {
        public async Task DeleteProductAsync(Product p) => await ProductDao.DeleteProductAsync(p);
        public async Task<List<Category>> GetCategoriesAsync() => await CategoryDao.GetCategoriesAsync();
        public async Task<Product> GetProductByIdAsync(int id) => await ProductDao.FindProductByIdAsync(id);
        public async Task<List<ProductDto>> GetProductsAsync() => await ProductDao.GetProductsAsync();
        public async Task SaveProductAsync(Product p) => await ProductDao.SaveProductAsync(p);
        public async Task UpdateProductAsync(Product p) => await ProductDao.UpdateProductAsync(p);
        public async Task<List<ProductDto>> SearchProductsAsync(string searchTerm) => await ProductDao.SearchProductsAsync(searchTerm);
    }
}
