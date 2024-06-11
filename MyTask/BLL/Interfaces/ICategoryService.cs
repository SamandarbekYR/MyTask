using MyTask.Entities;
using MyTask.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTask.BLL.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryView>> GetAllCategories();
    }
}
