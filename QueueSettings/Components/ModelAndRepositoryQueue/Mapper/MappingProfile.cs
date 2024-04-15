﻿using AutoMapper;
using BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.DataAccess.Data;
using BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.Models;

namespace BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<QueueEmployeeSettings, QueueEmployeeSettingsDTO>().ReverseMap();
            //CreateMap<CategoryDTO, Category>();
        }
    }
}
