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
    internal class StudentRepo : Repo,IRepo<Student,int>
    {
        public void Create(Student s) {
            db.Students.Add(s);
            db.SaveChanges();
        }
        public Student Get(int id) {

            return db.Students.Find(id);
        }
        public List<Student> Get() {
            return db.Students.ToList();
        }
        public void Update(Student s) {
            var exobj = Get(s.Id);
            db.Entry(exobj).CurrentValues.SetValues(s);
            db.SaveChanges();
        }
        public void Delete(int id) {
            var exobj = Get(id);
            db.Students.Remove(exobj);
            db.SaveChanges();


        }

        

    }
}
