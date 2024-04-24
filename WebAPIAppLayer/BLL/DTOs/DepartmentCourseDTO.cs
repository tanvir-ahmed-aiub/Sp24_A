using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DepartmentCourseDTO : DepartmentDTO
    {
        public List<CourseDTO>Courses { get; set; }
        public DepartmentCourseDTO() { 
            Courses = new List<CourseDTO>();
        }
    }
}
