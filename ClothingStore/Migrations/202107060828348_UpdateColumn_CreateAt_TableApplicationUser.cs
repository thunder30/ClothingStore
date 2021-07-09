namespace ClothingStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateColumn_CreateAt_TableApplicationUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "CreatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "CreatedAt", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
    }
}
