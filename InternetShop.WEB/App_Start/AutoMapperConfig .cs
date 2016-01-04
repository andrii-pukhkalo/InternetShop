using AutoMapper;
using InternetShop.BLL.DTO;
using InternetShop.WEB.Models;
using InternetShop.DAL.Entities;

namespace InternetShop.WEB.App_Start
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings() {
            Mapper.CreateMap<ProductDTO,        ProductViewModel>();
            Mapper.CreateMap<Product,           ProductDTO>()
                  .ForMember("Price", opt => opt.MapFrom(src => src.Details.Price));
        }
    }
}