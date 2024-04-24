namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeptAddedandPKFKDeptCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Courses", "DId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "DId");
            AddForeignKey("dbo.Courses", "DId", "dbo.Departments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "DId", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "DId" });
            DropColumn("dbo.Courses", "DId");
            DropTable("dbo.Departments");
        }
    }
}
