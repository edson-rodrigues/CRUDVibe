namespace CRUDVibe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabeladeEndereçosemudançanaspropriedadescorreção2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Pessoas");
            CreateTable(
                "dbo.Enderecoes",
                c => new
                    {
                        enderecoId = c.Int(nullable: false),
                        logradouro = c.String(maxLength: 50),
                        numero = c.String(maxLength: 5),
                        cep = c.String(maxLength: 8),
                        cidade = c.String(maxLength: 30),
                        estado = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.enderecoId)
                .ForeignKey("dbo.Pessoas", t => t.enderecoId)
                .Index(t => t.enderecoId);

            DropColumn("dbo.Pessoas", "id");
            AddColumn("dbo.Pessoas", "pessoaId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Pessoas", "nome", c => c.String(maxLength: 30));
            AlterColumn("dbo.Pessoas", "cpf", c => c.String(maxLength: 11));
            AlterColumn("dbo.Pessoas", "telefone", c => c.String(maxLength: 11));
            AddPrimaryKey("dbo.Pessoas", "pessoaId");
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pessoas", "id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Enderecoes", "enderecoId", "dbo.Pessoas");
            DropIndex("dbo.Enderecoes", new[] { "enderecoId" });
            DropPrimaryKey("dbo.Pessoas");
            AlterColumn("dbo.Pessoas", "telefone", c => c.String());
            AlterColumn("dbo.Pessoas", "cpf", c => c.String());
            AlterColumn("dbo.Pessoas", "nome", c => c.String());
            DropColumn("dbo.Pessoas", "pessoaId");
            DropTable("dbo.Enderecoes");
            AddPrimaryKey("dbo.Pessoas", "id");
        }
    }
}
