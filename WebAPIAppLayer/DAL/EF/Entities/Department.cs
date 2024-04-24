using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Course>Courses { get; set; }
        public Department() {
            Courses = new List<Course>();
        }
    }
}
