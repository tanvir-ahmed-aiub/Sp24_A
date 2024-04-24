using DAL.EF.Entities;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataFactory
    {
        public static IRepo<Course,int> CourseData() {
            return new CourseRepo();
        }
        public static IRepo<Student,int> StudentData() { 
            return new StudentRepo();
        }
        public static IRepo<Department, int> DepartmentData() {
            return new DepartmentRepo();
        }
    }
}
