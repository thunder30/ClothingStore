namespace ClothingStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateColumn_UpdateAt_ApplicationUser : DbMigration
    {
        public override void Up()
        {

            DropColumn("dbo.AspNetUsers", "UpdateAt");
        }
        
        public override void Down()
        {
            //AlterColumn("dbo.AspNetUsers", "UpdateAt", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
    }
}
