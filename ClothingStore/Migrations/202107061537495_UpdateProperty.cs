namespace ClothingStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProperty : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "CreatedAt", c => c.DateTime(defaultValueSql: "GETDATE()"));
        }
        
        public override void Down()
        {
        }
    }
}
