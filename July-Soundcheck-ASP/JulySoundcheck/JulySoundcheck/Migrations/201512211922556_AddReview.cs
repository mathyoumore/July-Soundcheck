namespace JulySoundcheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReview : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumId = c.Int(nullable: false, identity: true),
                        AlbumName = c.String(),
                        Artist_ArtistId = c.Int(),
                    })
                .PrimaryKey(t => t.AlbumId)
                .ForeignKey("dbo.Artists", t => t.Artist_ArtistId)
                .Index(t => t.Artist_ArtistId);
            
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistId = c.Int(nullable: false, identity: true),
                        ArtistName = c.String(),
                    })
                .PrimaryKey(t => t.ArtistId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        RevieweeId = c.Int(nullable: false),
                        Rating = c.Single(nullable: false),
                        AlbumId = c.Int(nullable: false),
                        ContentsShort = c.String(),
                        ContentsLong = c.String(),
                        User_UserId = c.Int(),
                        Artist_ArtistId = c.Int(),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.Albums", t => t.AlbumId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .ForeignKey("dbo.Artists", t => t.Artist_ArtistId)
                .Index(t => t.AlbumId)
                .Index(t => t.User_UserId)
                .Index(t => t.Artist_ArtistId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Artist_ArtistId", "dbo.Artists");
            DropForeignKey("dbo.Reviews", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Reviews", "AlbumId", "dbo.Albums");
            DropForeignKey("dbo.Albums", "Artist_ArtistId", "dbo.Artists");
            DropIndex("dbo.Reviews", new[] { "Artist_ArtistId" });
            DropIndex("dbo.Reviews", new[] { "User_UserId" });
            DropIndex("dbo.Reviews", new[] { "AlbumId" });
            DropIndex("dbo.Albums", new[] { "Artist_ArtistId" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Artists");
            DropTable("dbo.Albums");
        }
    }
}
