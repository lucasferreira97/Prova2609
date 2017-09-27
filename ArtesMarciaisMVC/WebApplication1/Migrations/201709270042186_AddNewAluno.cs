namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewAluno : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO dbo.Alunoes (Nome, CPF, Faixa, TipoDeAssociacao) VALUES ('Martim Castro Ribeiro', '158.778.735-04',1,1)");
            Sql("INSERT INTO dbo.Alunoes (Nome, CPF, Faixa, TipoDeAssociacao) VALUES ('Lucas Alves Melo', '916.749.332-74',4,3)");
            Sql("INSERT INTO dbo.Alunoes (Nome, CPF, Faixa, TipoDeAssociacao) VALUES ('Breno Castro Carvalho', '454.019.800-94',2,2)");
            Sql("INSERT INTO dbo.Alunoes (Nome, CPF, Faixa, TipoDeAssociacao) VALUES ('Laura Cardoso Rocha', '361.089.665-56',6,4)");

        }
        
        public override void Down()
        {
        }
    }
}
