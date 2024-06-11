using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTask.Entities.ViewModels
{
    public class CategoryView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
    }

    public class ApiResponse
    {
        public bool Status { get; set; }
        public Result Resoult { get; set; }
    }

    public class Result
    {
        public List<CategoryView> Data { get; set; }
    }
}
