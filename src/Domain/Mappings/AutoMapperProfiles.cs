using AutoMapper;
using Domain.DTOs;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Forest, ForestDTO>();
            CreateMap<ForestDTO, Forest>();

            CreateMap<Tree, TreeDTO>();
            CreateMap<TreeDTO, Tree>();
        }
    }
}
