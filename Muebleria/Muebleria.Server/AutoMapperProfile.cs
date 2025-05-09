using AutoMapper;
using Muebleria.Server.Data_Entities;
using Muebleria.Server.Models;


namespace Muebleria
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<CatalogoCreateModel, CatalogoEntity>()
                .ForMember(dest => dest.FechaRegistro, opt => opt.MapFrom(src => src.FechaAltaCatalogo))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.NombreArticulo));


            CreateMap<CatalogoEntity, CatalogoViewModel>()
                .ForMember(dest => dest.FechaAltaCatalogo, opt => opt.MapFrom(src => src.FechaRegistro))
                .ForMember(dest => dest.NombreArticulo , opt => opt.MapFrom(src => src.Descripcion));


        }
    }
} 
