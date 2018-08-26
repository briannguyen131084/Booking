namespace BookingBoss.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Product", "Event_Id", "dbo.Event");
            DropIndex("dbo.Product", new[] { "Event_Id" });
            DropColumn("dbo.Product", "Event_Id");
            DropTable("dbo.Event");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Event",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Product", "Event_Id", c => c.Long());
            CreateIndex("dbo.Product", "Event_Id");
            AddForeignKey("dbo.Product", "Event_Id", "dbo.Event", "Id");
        }
    }
}
