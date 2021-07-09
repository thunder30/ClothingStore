namespace ClothingStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateColumn_CreateAt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "CreatedAt", c => c.DateTime(nullable: true, defaultValueSql: "GETDATE()"));
        }
        
        public override void Down()
        {
        }
    }
}
