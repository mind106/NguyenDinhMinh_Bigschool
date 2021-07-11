namespace NguyenDinhMinh_Bigschool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFollowingsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Followings",
                c => new
                    {
                        FollwerId = c.String(nullable: false, maxLength: 128),
                        FollweeId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.FollwerId, t.FollweeId })
                .ForeignKey("dbo.AspNetUsers", t => t.FollwerId)
                .ForeignKey("dbo.AspNetUsers", t => t.FollweeId)
                .Index(t => t.FollwerId)
                .Index(t => t.FollweeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Followings", "FollweeId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Followings", "FollwerId", "dbo.AspNetUsers");
            DropIndex("dbo.Followings", new[] { "FollweeId" });
            DropIndex("dbo.Followings", new[] { "FollwerId" });
            DropTable("dbo.Followings");
        }
    }
}
