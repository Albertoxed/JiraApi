using ApiJira.Dto;
using ApiJira.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJira.Mappings
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Issue, IssueDto>()
                .ReverseMap();
            CreateMap<Employee, EmployeeDto>()
                .ReverseMap();
        }

    }
}
