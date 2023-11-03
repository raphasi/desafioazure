using AutoMapper;
using ShopTFTEC.API.Models;

namespace ShopTFTEC.API.DTOs.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CartDTO, Cart>().ReverseMap();
        CreateMap<CartHeaderDTO, CartHeader>().ReverseMap();
        CreateMap<CartItemDTO, CartItem>().ReverseMap();
        CreateMap<ProductDTO, Product>().ReverseMap();
        CreateMap<CouponDTO, Coupon>().ReverseMap();

        CreateMap<Category, CategoryDTO>().ReverseMap();

        CreateMap<ProductDTO, Product>();
        CreateMap<Product, ProductDTO>()
         .ForMember(x => x.CategoryName, opt => opt.MapFrom(src => src.Category.Name));
    }
}
