namespace BestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class plant2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Leaves", "LeafConnectionId", "dbo.LeafConnections");
            DropForeignKey("dbo.Leaves", "LeafLocationId", "dbo.LeafLocations");
            DropForeignKey("dbo.Leaves", "LeafMarginId", "dbo.LeafMargins");
            DropForeignKey("dbo.Leaves", "LeafShapeId", "dbo.LeafShapes");
            DropForeignKey("dbo.Leaves", "LeafThicknessId", "dbo.LeafThicknesses");
            DropForeignKey("dbo.Leaves", "LeafVenationId", "dbo.LeafVenations");
            DropIndex("dbo.Leaves", new[] { "LeafThicknessId" });
            DropIndex("dbo.Leaves", new[] { "LeafLocationId" });
            DropIndex("dbo.Leaves", new[] { "LeafConnectionId" });
            DropIndex("dbo.Leaves", new[] { "LeafVenationId" });
            DropIndex("dbo.Leaves", new[] { "LeafShapeId" });
            DropIndex("dbo.Leaves", new[] { "LeafMarginId" });
            AlterColumn("dbo.Leaves", "LeafThicknessId", c => c.Int());
            AlterColumn("dbo.Leaves", "LeafLocationId", c => c.Int());
            AlterColumn("dbo.Leaves", "LeafConnectionId", c => c.Int());
            AlterColumn("dbo.Leaves", "LeafVenationId", c => c.Int());
            AlterColumn("dbo.Leaves", "LeafShapeId", c => c.Int());
            AlterColumn("dbo.Leaves", "LeafMarginId", c => c.Int());
            AlterColumn("dbo.Plants", "MinTemperature", c => c.Int());
            AlterColumn("dbo.Plants", "MaxTemperature", c => c.Int());
            AlterColumn("dbo.Plants", "Rating", c => c.Int());
            AlterColumn("dbo.Plants", "Views", c => c.Int());
            AlterColumn("dbo.Plants", "CommentNumber", c => c.Int());
            AlterColumn("dbo.Plants", "Time", c => c.DateTime());
            AlterColumn("dbo.Plants", "AveragePriceRub", c => c.Single());
            AlterColumn("dbo.Plants", "AveragePriceGrn", c => c.Single());
            AlterColumn("dbo.Plants", "AveragePriceEuro", c => c.Single());
            AlterColumn("dbo.Plants", "AveragePriceDollar", c => c.Single());
            CreateIndex("dbo.Leaves", "LeafThicknessId");
            CreateIndex("dbo.Leaves", "LeafLocationId");
            CreateIndex("dbo.Leaves", "LeafConnectionId");
            CreateIndex("dbo.Leaves", "LeafVenationId");
            CreateIndex("dbo.Leaves", "LeafShapeId");
            CreateIndex("dbo.Leaves", "LeafMarginId");
            AddForeignKey("dbo.Leaves", "LeafConnectionId", "dbo.LeafConnections", "Id");
            AddForeignKey("dbo.Leaves", "LeafLocationId", "dbo.LeafLocations", "Id");
            AddForeignKey("dbo.Leaves", "LeafMarginId", "dbo.LeafMargins", "Id");
            AddForeignKey("dbo.Leaves", "LeafShapeId", "dbo.LeafShapes", "Id");
            AddForeignKey("dbo.Leaves", "LeafThicknessId", "dbo.LeafThicknesses", "Id");
            AddForeignKey("dbo.Leaves", "LeafVenationId", "dbo.LeafVenations", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Leaves", "LeafVenationId", "dbo.LeafVenations");
            DropForeignKey("dbo.Leaves", "LeafThicknessId", "dbo.LeafThicknesses");
            DropForeignKey("dbo.Leaves", "LeafShapeId", "dbo.LeafShapes");
            DropForeignKey("dbo.Leaves", "LeafMarginId", "dbo.LeafMargins");
            DropForeignKey("dbo.Leaves", "LeafLocationId", "dbo.LeafLocations");
            DropForeignKey("dbo.Leaves", "LeafConnectionId", "dbo.LeafConnections");
            DropIndex("dbo.Leaves", new[] { "LeafMarginId" });
            DropIndex("dbo.Leaves", new[] { "LeafShapeId" });
            DropIndex("dbo.Leaves", new[] { "LeafVenationId" });
            DropIndex("dbo.Leaves", new[] { "LeafConnectionId" });
            DropIndex("dbo.Leaves", new[] { "LeafLocationId" });
            DropIndex("dbo.Leaves", new[] { "LeafThicknessId" });
            AlterColumn("dbo.Plants", "AveragePriceDollar", c => c.Single(nullable: false));
            AlterColumn("dbo.Plants", "AveragePriceEuro", c => c.Single(nullable: false));
            AlterColumn("dbo.Plants", "AveragePriceGrn", c => c.Single(nullable: false));
            AlterColumn("dbo.Plants", "AveragePriceRub", c => c.Single(nullable: false));
            AlterColumn("dbo.Plants", "Time", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Plants", "CommentNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Plants", "Views", c => c.Int(nullable: false));
            AlterColumn("dbo.Plants", "Rating", c => c.Int(nullable: false));
            AlterColumn("dbo.Plants", "MaxTemperature", c => c.Int(nullable: false));
            AlterColumn("dbo.Plants", "MinTemperature", c => c.Int(nullable: false));
            AlterColumn("dbo.Leaves", "LeafMarginId", c => c.Int(nullable: false));
            AlterColumn("dbo.Leaves", "LeafShapeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Leaves", "LeafVenationId", c => c.Int(nullable: false));
            AlterColumn("dbo.Leaves", "LeafConnectionId", c => c.Int(nullable: false));
            AlterColumn("dbo.Leaves", "LeafLocationId", c => c.Int(nullable: false));
            AlterColumn("dbo.Leaves", "LeafThicknessId", c => c.Int(nullable: false));
            CreateIndex("dbo.Leaves", "LeafMarginId");
            CreateIndex("dbo.Leaves", "LeafShapeId");
            CreateIndex("dbo.Leaves", "LeafVenationId");
            CreateIndex("dbo.Leaves", "LeafConnectionId");
            CreateIndex("dbo.Leaves", "LeafLocationId");
            CreateIndex("dbo.Leaves", "LeafThicknessId");
            AddForeignKey("dbo.Leaves", "LeafVenationId", "dbo.LeafVenations", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Leaves", "LeafThicknessId", "dbo.LeafThicknesses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Leaves", "LeafShapeId", "dbo.LeafShapes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Leaves", "LeafMarginId", "dbo.LeafMargins", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Leaves", "LeafLocationId", "dbo.LeafLocations", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Leaves", "LeafConnectionId", "dbo.LeafConnections", "Id", cascadeDelete: true);
        }
    }
}
