namespace ClothingStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnOnTableApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.AspNetUsers", "Gender", c => c.Byte(nullable: false));
            AddColumn("dbo.AspNetUsers", "Birthday", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Avatar", c => c.String(maxLength: 8000, unicode: false));
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address", c => c.String());
            AddColumn("dbo.AspNetUsers", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "UpdateAt", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "UpdateAt");
            DropColumn("dbo.AspNetUsers", "CreatedAt");
            DropColumn("dbo.AspNetUsers", "Address");
            DropColumn("dbo.AspNetUsers", "Phone");
            DropColumn("dbo.AspNetUsers", "Avatar");
            DropColumn("dbo.AspNetUsers", "Birthday");
            DropColumn("dbo.AspNetUsers", "Gender");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "LastName");
        }
    }
}
