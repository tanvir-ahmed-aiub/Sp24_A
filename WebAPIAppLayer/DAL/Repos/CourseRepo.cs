using DAL.EF;
using DAL.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CourseRepo
    {
        UMSContext db = new UMSContext();
        public void Create(Course c) {
            db.Courses.Add(c);
            db.SaveChanges();
        }
        public Course Get(int id)
        {
            return db.Courses.Find(id);
            //return new Course() { Id = id,Name="Dummy" };//
        }
        public List<Course> Get()
        {
            return db.Courses.ToList();
        }
        public void Update(Course s)
        {
            var exobj = Get(s.Id);
            db.Entry(exobj).CurrentValues.SetValues(s);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var exobj = Get(id);
            db.Courses.Remove(exobj);
            db.SaveChanges();
        }
    }
}
