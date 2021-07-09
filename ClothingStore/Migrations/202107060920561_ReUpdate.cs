namespace ClothingStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "CreatedAt", c => c.DateTime(nullable: true, defaultValueSql: "getdate()"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "CreatedAt", c => c.DateTime());
        }
    }
}
