namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.UMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.UMSContext context)
        {
            //var names = new string[] { "CS","BBA","EEE","Math","Physics"};
            //foreach (var item in names)
            //{
            //    context.Departments.Add(
            //        new EF.Entities.Department() { 
            //            Name = item,
            //        });
            //}
            //context.SaveChanges();
            Random random = new Random();

            for (int i = 0; i < 50; i++) {
                context.Courses.Add(
                        new EF.Entities.Course() { 
                            Name = Guid.NewGuid().ToString().Substring(0,6),
                            DId = random.Next(1,6)
                        }
                    );
            }
            context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
