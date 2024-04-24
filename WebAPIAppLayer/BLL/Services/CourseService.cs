using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Entities;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CourseService
    {
        public static CourseDTO Get(int id) { 
            var data = DataFactory.CourseData().Get(id);
            var config = new MapperConfiguration(cfg => { 
                cfg.CreateMap<Course,CourseDTO>();
            });
            var mapper = new Mapper(config);
            var ret = mapper.Map<CourseDTO>(data);
            return ret;
        }
        public static void Create(CourseDTO c) {
            //convert courseDTO to Course
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CourseDTO,Course>();
            });
            var mapper = new Mapper(config);
            var crs = mapper.Map<Course>(c);
            DataFactory.CourseData().Create(crs);
        }
        public static List<CourseDTO> Get() { 
            var data = DataFactory.CourseData().Get(); //List<Course> ef model

            //mapper
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Course,CourseDTO>();
            });
            var mapper = new Mapper(config);
            var retdata = mapper.Map<List<CourseDTO>>(data);

      
            return retdata;
        }

    }
}
