namespace API.AplicativoMOB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionarProfessor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Titulo = c.String(),
                        Email = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Professors");
        }
    }
}
