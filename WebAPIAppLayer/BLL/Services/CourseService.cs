using BLL.DTOs;
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
        public static void Create(CourseDTO c) { 
            //convert courseDTO to Course
            Course cd = new Course(); //converted course
            new CourseRepo().Create(cd);
        }
        public static List<CourseDTO> Get() { 
            var data = new CourseRepo().Get(); //List<Course>
            //convert to CourseDTO
            var list = new List<CourseDTO>();
            return list;
        }

    }
}
