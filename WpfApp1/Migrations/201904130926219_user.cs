namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CRUD_Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 75),
                        LastName = c.String(nullable: false, maxLength: 75),
                        Email = c.String(nullable: false, maxLength: 75),
                        Password = c.String(nullable: false, maxLength: 75),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CRUD_Users");
        }
    }
}
