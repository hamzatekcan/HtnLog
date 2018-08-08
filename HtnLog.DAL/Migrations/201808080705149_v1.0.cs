namespace HtnLog.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contents",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tittle = c.String(),
                        text = c.String(),
                        defaultImage = c.String(),
                        active = c.Boolean(nullable: false),
                        uploadDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        surname = c.String(),
                        authority = c.String(),
                        active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Contents");
        }
    }
}
