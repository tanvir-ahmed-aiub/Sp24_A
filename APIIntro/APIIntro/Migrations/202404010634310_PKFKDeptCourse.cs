namespace APIIntro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PKFKDeptCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "DeptId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "DeptId");
            AddForeignKey("dbo.Courses", "DeptId", "dbo.Departments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "DeptId", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "DeptId" });
            DropColumn("dbo.Courses", "DeptId");
        }
    }
}
