using Newtonsoft.Json;

namespace BookingBossTest.Model
{
    public class ProductModel
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }

        [JsonProperty(PropertyName = "sale_amount")]
        public double SaleAmount { get; set; }
    }

    public class ProductsModel
    {
        
    }
}