using AutoMapper;
using CMS.BLL.DTO;
using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BLL.Auto_Mapper
{
    public class MappingProfile :Profile 

    {
        public MappingProfile()
        {
            CreateMap<Students, StudentAddDto>();
            CreateMap<Students, StudentReadDto>();
            CreateMap<Students, StudentUpdateDto>();


           
        }
    }
}
