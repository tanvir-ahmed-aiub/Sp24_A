using DAL.EF.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CourseRepoV2 : IRepo<Course,int>
    {
        public void Create(Course obj)
        {
            throw new NotImplementedException();
        }

        public void CreateCourse() { }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> Get()
        {
            throw new NotImplementedException();
        }

        public Course Get(int id)
        {
            throw new NotImplementedException();
        }

        public void GetCourse() { }

        public void Update(Course obj)
        {
            throw new NotImplementedException();
        }
    }
}
