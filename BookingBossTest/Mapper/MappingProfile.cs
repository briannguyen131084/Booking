using AutoMapper;
using BookingBoss.Domain;
using BookingBossTest.Model;

namespace BookingBossTest.Mapper
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<ProductEntity, ProductModel>()
                .ReverseMap();
        }
    }
}