namespace ClothingStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable_Categories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(),
                        Image = c.String(unicode: false, storeType: "text"),
                        CreatedAt = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        UpdateAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
