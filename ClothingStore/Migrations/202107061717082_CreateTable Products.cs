namespace ClothingStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableProducts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 25),
                        Name = c.String(nullable: false, maxLength: 255),
                        Image = c.String(unicode: false, storeType: "text"),
                        ShortDescription = c.String(maxLength: 255),
                        Description = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 0),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 0),
                        Unit = c.String(maxLength: 50),
                        Discontinued = c.Boolean(nullable: false, defaultValue: false),
                        IsFeatured = c.Boolean(nullable: false, defaultValue: false),
                        IsNew = c.Boolean(nullable: false, defaultValue: false),
                        CreatedAt = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        UpdateAt = c.DateTime(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
                        
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId" });            
            DropTable("dbo.Products");
        }
    }
}
