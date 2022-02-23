namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameKategoriİsimToKategoriAdiInKategorisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "KategoriAdi", c => c.String());
            AddColumn("dbo.Kategoris", "KategoriDetay", c => c.String());
            DropColumn("dbo.Kategoris", "KategoriAD");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoris", "KategoriAD", c => c.String());
            DropColumn("dbo.Kategoris", "KategoriDetay");
            DropColumn("dbo.Kategoris", "KategoriAdi");
        }
    }
}
