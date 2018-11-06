namespace FSBeheer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false, storeType: "ntext"),
                        QuestionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.QuestionId, cascadeDelete: true)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false, storeType: "ntext"),
                        QuestionTypeId = c.Int(nullable: false),
                        QuestionnaireId = c.Int(nullable: false),
                        Options = c.String(),
                        Columns = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questionnaires", t => t.QuestionnaireId, cascadeDelete: true)
                .ForeignKey("dbo.QuestionTypes", t => t.QuestionTypeId, cascadeDelete: true)
                .Index(t => t.QuestionTypeId)
                .Index(t => t.QuestionnaireId);
            
            CreateTable(
                "dbo.Questionnaires",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InspectionId = c.Int(nullable: false),
                        Instructions = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.QuestionTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Inspections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Password = c.String(),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Questions", "QuestionTypeId", "dbo.QuestionTypes");
            DropForeignKey("dbo.Questions", "QuestionnaireId", "dbo.Questionnaires");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropIndex("dbo.Accounts", new[] { "RoleId" });
            DropIndex("dbo.Questions", new[] { "QuestionnaireId" });
            DropIndex("dbo.Questions", new[] { "QuestionTypeId" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropTable("dbo.Accounts");
            DropTable("dbo.Roles");
            DropTable("dbo.Inspections");
            DropTable("dbo.QuestionTypes");
            DropTable("dbo.Questionnaires");
            DropTable("dbo.Questions");
            DropTable("dbo.Answers");
        }
    }
}
