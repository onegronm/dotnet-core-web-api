using System;
namespace WebApplication1.Classes
{
    public class ProductQueryParameters : QueryParameters
    {
        public String Sku { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public string Name { get; set; }
    }
}
