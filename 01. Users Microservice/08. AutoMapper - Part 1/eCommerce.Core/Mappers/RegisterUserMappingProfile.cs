using AutoMapper;
using eCommerce.Core.DTO;
using eCommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eCommerce.Core.Mappers
{
    public class RegisterUserMappingProfile : Profile
    {
        public RegisterUserMappingProfile() {
            CreateMap<RegisterRequest, ApplicationUser>()
                .ForMember(dest => dest.UserID, opt => opt.Ignore())
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
                .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src => src.PersonName))
                ;
        }
    }
}
