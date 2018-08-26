using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingBoss.Domain
{
    [Table("Product")]
    public class ProductEntity : Entity
    {
        [MaxLength(250)]
        public string Name { get; set; }

        public int Quantity { get; set; }

        public double SaleAmount { get; set; }
    }
}
