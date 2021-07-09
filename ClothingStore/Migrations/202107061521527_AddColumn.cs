namespace ClothingStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "CreatedAt", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "UpdateAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            //AlterColumn("dbo.AspNetUsers", "UpdateAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AspNetUsers", "CreatedAt", c => c.DateTime(nullable: false));
        }
    }
}
