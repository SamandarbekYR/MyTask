using MyTask.Entities;
using System.Threading.Tasks;

namespace MyTask.BLL.Interfaces
{
    public interface IProductService
    {
        Task<Products> GetProductsAsync();
    }
}
