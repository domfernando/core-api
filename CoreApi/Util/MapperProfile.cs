using AutoMapper;
using Core.Domain.Acesso;
using CoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.Util
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            //CreateMap<User, UserLoginDTO>().ReverseMap();
        }
    }
}
