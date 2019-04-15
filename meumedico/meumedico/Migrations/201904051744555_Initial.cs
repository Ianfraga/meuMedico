namespace meumedico.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medico",
                c => new
                    {
                        MedicoID = c.Int(nullable: false, identity: true),
                        Conselho = c.String(),
                        Nome = c.String(),
                        Especialidade = c.String(),
                    })
                .PrimaryKey(t => t.MedicoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Medico");
        }
    }
}
