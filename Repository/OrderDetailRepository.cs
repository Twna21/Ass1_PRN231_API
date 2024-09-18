using BussinessObject;
using DataAccess;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public async Task DeleteOrderDetailAsync(OrderDetail p) => await OrderDetailDAO.DeleteOrderDetailAsync(p);
        public async Task<List<Category>> GetCategoriesAsync() => await CategoryDao.GetCategoriesAsync();
        public async Task<OrderDetail> GetOrderDetailByIdAsync(int id) => await OrderDetailDAO.FindOrderDetailByIdAsync(id);
        public async Task<List<OrderDetail>> GetOrderDetailsAsync() => await OrderDetailDAO.GetOrderDetailsAsync();
        public async Task SaveOrderDetailAsync(OrderDetail p) => await OrderDetailDAO.SaveOrderDetailAsync(p);
        public async Task UpdateOrderDetailAsync(OrderDetail p) => await OrderDetailDAO.UpdateOrderDetailAsync(p);
    }
}
