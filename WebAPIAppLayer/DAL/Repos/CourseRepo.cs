using DAL.EF;
using DAL.EF.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CourseRepo :Repo, IRepo<Course, int>
    {
        public void Create(Course obj)
        {
            db.Courses.Add(obj);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var exobj = Get(id);
            db.Courses.Remove(exobj);
            db.SaveChanges();
        }

        public List<Course> Get()
        {
            return db.Courses.ToList();
        }

        public Course Get(int id)
        {
            return db.Courses.Find(id); 
        }

        public void Update(Course obj)
        {
            var exobj = Get(obj.Id);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            db.SaveChanges();
        }
    }
}
