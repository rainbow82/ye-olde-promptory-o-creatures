namespace ye_olde_promptory_o_creatures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Birthday : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Conferences",
                c => new
                    {
                        ConferenceId = c.Int(nullable: false, identity: true),
                        ConferenceName = c.String(),
                        ConferenceDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ConferenceId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Conferences");
        }
    }
}
