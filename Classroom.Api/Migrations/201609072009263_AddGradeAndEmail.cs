namespace Classroom.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGradeAndEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Assignments", "Grade", c => c.String());
            AddColumn("dbo.Students", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Email");
            DropColumn("dbo.Assignments", "Grade");
        }
    }
}
