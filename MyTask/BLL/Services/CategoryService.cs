using MyTask.BLL.Interfaces;
using MyTask.Entities;
using MyTask.Entities.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyTask.BLL.Services
{
    public class CategoryService : ICategoryService
    {
        public async Task<List<CategoryView>> GetAllCategories()
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://bb6d-91-196-77-120.ngrok-free.app/api/category/index");

                HttpResponseMessage responseMessage = await client.GetAsync(client.BaseAddress);
                string response = await responseMessage.Content.ReadAsStringAsync();

                // JSON ni deserializatsiya qilish
                ApiResponse responseObject = JsonConvert.DeserializeObject<ApiResponse>(response);

                // List<Products> qaytarish
                return responseObject.Resoult.Data;
            }
            catch (Exception ex)
            {
                return new List<CategoryView>();
            }
        }
    }
}
