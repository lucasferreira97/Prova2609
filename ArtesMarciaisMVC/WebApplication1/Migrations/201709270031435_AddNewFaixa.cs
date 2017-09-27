namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewFaixa : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Faixas (Nome, Graus) VALUES ('Branca', '6k')");
            Sql("INSERT INTO dbo.Faixas (Nome, Graus) VALUES ('Amarela', '5k')");
            Sql("INSERT INTO dbo.Faixas (Nome, Graus) VALUES ('Roxa', '4k')");
            Sql("INSERT INTO dbo.Faixas (Nome, Graus) VALUES ('Verde', '3k')");
            Sql("INSERT INTO dbo.Faixas (Nome, Graus) VALUES ('Azul', '2k')");
            Sql("INSERT INTO dbo.Faixas (Nome, Graus) VALUES ('Marrom', '1k')");
            Sql("INSERT INTO dbo.Faixas (Nome, Graus) VALUES ('Preta', '1d')");
        }
        
        public override void Down()
        {
        }
    }
}
