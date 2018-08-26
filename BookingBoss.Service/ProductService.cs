using BookingBoss.Domain;
using BookingBoss.Infrastructure;

namespace BookingBoss.Service
{
    public class ProductService : EntityService<ProductEntity>, IProductService
    {
        public ProductService(IContext context) : base(context)
        {
        }
    }
}
