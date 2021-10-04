namespace Trabalho.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunoes",
                c => new
                    {
                        AlunoId = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                        nomeCurso = c.String(),
                        Termo = c.String(),
                    })
                .PrimaryKey(t => t.AlunoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Alunoes");
        }
    }
}
