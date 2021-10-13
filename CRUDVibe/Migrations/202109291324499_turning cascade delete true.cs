namespace CRUDVibe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class turningcascadedeletetrue : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enderecoes", "enderecoId", "dbo.Pessoas");
            AddForeignKey("dbo.Enderecoes", "enderecoId", "dbo.Pessoas", "pessoaId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enderecoes", "enderecoId", "dbo.Pessoas");
            AddForeignKey("dbo.Enderecoes", "enderecoId", "dbo.Pessoas", "pessoaId");
        }
    }
}
