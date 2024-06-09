using _TechTore_BLL.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTore_DAL.Models;

namespace _TechTore_BLL.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Accounting, AccountingDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Cart, CartWithItemsDTO>().ReverseMap();
            CreateMap<CartItem, CartItemDTO>().ReverseMap();
        }
    }
}
