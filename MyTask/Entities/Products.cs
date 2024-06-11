using System.Collections.Generic;

namespace MyTask.Entities
{
    public class Products
    {

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Categories Category { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Count { get; set; }
        public string Date { get; set; }
    }

    public class ProductResponse
    {
        public bool Status { get; set; }
        public ProductResult Resoult { get; set; }
    }

    public class ProductResult
    {
        public List<Products> Data { get; set; }
    }
}
