namespace WebApplicationTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SampleDataBindingModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestNumber = c.Int(nullable: false),
                        RequestTitle = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SampleDataBindingModels");
        }
    }
}
