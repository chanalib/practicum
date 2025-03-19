using AutoMapper;
using MagicalMusic.CORE.DTOs;
using MagicalMusic.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalMusic.CORE
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerDTO, Customer>().ReverseMap();
            CreateMap<CustomerUpdate, Customer>().ReverseMap();
            CreateMap<CustomerPost, Customer>().ReverseMap();

            CreateMap<ProductDTO, Album>().ReverseMap();
            CreateMap<ProductGetDTO, Album>().ReverseMap();
            CreateMap<ProductUpdate, Album>().ReverseMap();

            CreateMap<AdvertisterDTO, Advertiser>().ReverseMap();
            CreateMap<userPost, Advertiser>().ReverseMap();
            CreateMap<userUpdate, Advertiser>().ReverseMap();

        }
    }
}
