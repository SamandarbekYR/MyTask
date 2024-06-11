using MyTask.BLL.Interfaces;
using MyTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTask.BLL.Services
{
    using MyTask.Entities.ViewModels;
    using Newtonsoft.Json;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;

    public class ProductService
    {
        
        public async Task<List<Products>> GetProductsAsync()
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://bb6d-91-196-77-120.ngrok-free.app/api/product/index");

                HttpResponseMessage responseMessage = await client.GetAsync(client.BaseAddress);
                string response = await responseMessage.Content.ReadAsStringAsync();

                // JSON ni deserializatsiya qilish
                ProductResponse responseObject = JsonConvert.DeserializeObject<ProductResponse>(response);

                // List<Products> qaytarish
                return responseObject.Resoult.Data;
            }
            catch (Exception ex)
            {
                return new List<Products>();
            }
        }
    }

}
