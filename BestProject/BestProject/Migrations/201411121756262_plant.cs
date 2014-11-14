namespace BestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class plant : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LeafColors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameRu = c.String(nullable: false, maxLength: 20),
                        NameEn = c.String(nullable: false, maxLength: 20),
                        PictureUrl = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Leaves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PictureUrl = c.String(nullable: false, maxLength: 100),
                        CompoundLeafUrl = c.String(maxLength: 100),
                        LeafThicknessId = c.Int(nullable: false),
                        LeafLocationId = c.Int(nullable: false),
                        LeafConnectionId = c.Int(nullable: false),
                        LeafVenationId = c.Int(nullable: false),
                        LeafShapeId = c.Int(nullable: false),
                        LeafMarginId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LeafConnections", t => t.LeafConnectionId, cascadeDelete: true)
                .ForeignKey("dbo.LeafLocations", t => t.LeafLocationId, cascadeDelete: true)
                .ForeignKey("dbo.LeafMargins", t => t.LeafMarginId, cascadeDelete: true)
                .ForeignKey("dbo.LeafShapes", t => t.LeafShapeId, cascadeDelete: true)
                .ForeignKey("dbo.LeafThicknesses", t => t.LeafThicknessId, cascadeDelete: true)
                .ForeignKey("dbo.LeafVenations", t => t.LeafVenationId, cascadeDelete: true)
                .Index(t => t.LeafThicknessId)
                .Index(t => t.LeafLocationId)
                .Index(t => t.LeafConnectionId)
                .Index(t => t.LeafVenationId)
                .Index(t => t.LeafShapeId)
                .Index(t => t.LeafMarginId);
            
            CreateTable(
                "dbo.LeafConnections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameRu = c.String(nullable: false, maxLength: 20),
                        NameEn = c.String(nullable: false, maxLength: 20),
                        PictureUrl = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LeafLocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameRu = c.String(nullable: false, maxLength: 20),
                        NameEn = c.String(nullable: false, maxLength: 20),
                        PictureUrl = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LeafMargins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameRu = c.String(nullable: false, maxLength: 20),
                        NameEn = c.String(nullable: false, maxLength: 20),
                        PictureUrl = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LeafShapes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameRu = c.String(nullable: false, maxLength: 20),
                        NameEn = c.String(nullable: false, maxLength: 20),
                        PictureUrl = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LeafThicknesses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameRu = c.String(nullable: false, maxLength: 20),
                        NameEn = c.String(nullable: false, maxLength: 20),
                        PictureUrl = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LeafVenations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameRu = c.String(nullable: false, maxLength: 20),
                        NameEn = c.String(nullable: false, maxLength: 20),
                        PictureUrl = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Plants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameRu = c.String(nullable: false, maxLength: 20),
                        NamEn = c.String(maxLength: 20),
                        BotanicalName = c.String(nullable: false, maxLength: 20),
                        DescriptionRu = c.String(nullable: false, unicode: false, storeType: "text"),
                        DescriptioEen = c.String(unicode: false, storeType: "text"),
                        TransplantRu = c.String(nullable: false, unicode: false, storeType: "text"),
                        TransplantEn = c.String(unicode: false, storeType: "text"),
                        PossibleProblemsRu = c.String(nullable: false, unicode: false, storeType: "text"),
                        PossibleProblemsEn = c.String(unicode: false, storeType: "text"),
                        WikiUrlRu = c.String(nullable: false, maxLength: 100),
                        WikiUrlEn = c.String(maxLength: 100),
                        GrowthDurationRu = c.String(nullable: false, maxLength: 20),
                        GrowthDurationEn = c.String(maxLength: 20),
                        MinHeightRu = c.Int(),
                        MinHeightEn = c.Int(),
                        MaxHeightRu = c.Int(),
                        MaxHeightEn = c.Int(),
                        MinTemperature = c.Int(nullable: false),
                        MaxTemperature = c.Int(nullable: false),
                        Rating = c.Int(nullable: false),
                        Views = c.Int(nullable: false),
                        CommentNumber = c.Int(nullable: false),
                        Time = c.DateTime(nullable: false),
                        PictureUrl = c.String(nullable: false, maxLength: 100),
                        AveragePriceRub = c.Single(nullable: false),
                        AveragePriceGrn = c.Single(nullable: false),
                        AveragePriceEuro = c.Single(nullable: false),
                        AveragePriceDollar = c.Single(nullable: false),
                        LeafId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Leaves", t => t.LeafId)
                .Index(t => t.LeafId);
            
            CreateTable(
                "dbo.LeafLeafColors",
                c => new
                    {
                        Leaf_Id = c.Int(nullable: false),
                        LeafColor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Leaf_Id, t.LeafColor_Id })
                .ForeignKey("dbo.Leaves", t => t.Leaf_Id, cascadeDelete: true)
                .ForeignKey("dbo.LeafColors", t => t.LeafColor_Id, cascadeDelete: true)
                .Index(t => t.Leaf_Id)
                .Index(t => t.LeafColor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Plants", "LeafId", "dbo.Leaves");
            DropForeignKey("dbo.Leaves", "LeafVenationId", "dbo.LeafVenations");
            DropForeignKey("dbo.Leaves", "LeafThicknessId", "dbo.LeafThicknesses");
            DropForeignKey("dbo.Leaves", "LeafShapeId", "dbo.LeafShapes");
            DropForeignKey("dbo.Leaves", "LeafMarginId", "dbo.LeafMargins");
            DropForeignKey("dbo.Leaves", "LeafLocationId", "dbo.LeafLocations");
            DropForeignKey("dbo.Leaves", "LeafConnectionId", "dbo.LeafConnections");
            DropForeignKey("dbo.LeafLeafColors", "LeafColor_Id", "dbo.LeafColors");
            DropForeignKey("dbo.LeafLeafColors", "Leaf_Id", "dbo.Leaves");
            DropIndex("dbo.LeafLeafColors", new[] { "LeafColor_Id" });
            DropIndex("dbo.LeafLeafColors", new[] { "Leaf_Id" });
            DropIndex("dbo.Plants", new[] { "LeafId" });
            DropIndex("dbo.Leaves", new[] { "LeafMarginId" });
            DropIndex("dbo.Leaves", new[] { "LeafShapeId" });
            DropIndex("dbo.Leaves", new[] { "LeafVenationId" });
            DropIndex("dbo.Leaves", new[] { "LeafConnectionId" });
            DropIndex("dbo.Leaves", new[] { "LeafLocationId" });
            DropIndex("dbo.Leaves", new[] { "LeafThicknessId" });
            DropTable("dbo.LeafLeafColors");
            DropTable("dbo.Plants");
            DropTable("dbo.LeafVenations");
            DropTable("dbo.LeafThicknesses");
            DropTable("dbo.LeafShapes");
            DropTable("dbo.LeafMargins");
            DropTable("dbo.LeafLocations");
            DropTable("dbo.LeafConnections");
            DropTable("dbo.Leaves");
            DropTable("dbo.LeafColors");
        }
    }
}
