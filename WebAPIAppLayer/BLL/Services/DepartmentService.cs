using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DepartmentService
    {
        public static List<DepartmentDTO> Get() {
            var data = DataFactory.DepartmentData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Department, DepartmentDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<DepartmentDTO>>(data);
        }
        public static DepartmentDTO Get(int id)
        {
            var data = DataFactory.DepartmentData().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Department, DepartmentDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<DepartmentDTO>(data);
        }
        public static DepartmentCourseDTO GetwithCourse(int id) { 
            var data = DataFactory.DepartmentData().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Department, DepartmentCourseDTO>();
                cfg.CreateMap<Course, CourseDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<DepartmentCourseDTO>(data);

        }
    }
}
