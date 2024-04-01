namespace APIIntro.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<APIIntro.EF.PersonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(APIIntro.EF.PersonContext context)
        {
            Random rand = new Random();
            for (int i = 0; i < 1000; i++) {
                APIIntro.EF.Tbls.Course c = new EF.Tbls.Course();
                c.Name = Guid.NewGuid().ToString().Substring(0, 5);
                c.DeptId = rand.Next(2, 10);
                context.Courses.Add(c);
            }
            context.SaveChanges();

            //string[] names = {"CS","EEE","IPE","COE","MATH","PHYSICS","CHEMISTRY","ACCOUNTING" };
            //foreach (var item in names) {
            //    context.Departments.AddOrUpdate(
            //        new EF.Tbls.Department() { Name=item,Established=DateTime.Now});
            //}
            //context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
