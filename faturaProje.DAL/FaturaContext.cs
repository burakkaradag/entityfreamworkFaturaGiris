namespace faturaProje.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using static faturaProje.ENT.Entities;

    public class FaturaContext : DbContext
    {
        // Your context has been configured to use a 'FaturaContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'faturaProje.DAL.FaturaContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'FaturaContext' 
        // connection string in the application configuration file.
        public FaturaContext()
            : base("baglanti")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<FaturaMaster> FaturaMaster { get; set; }
        public virtual DbSet<FaturaDetay> FaturaDetay { get; set; }
        public virtual DbSet<Urun> Urun { get; set; }
        public virtual DbSet<Birim> Birim { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<Ilce> Ilce { get; set; }
        public virtual DbSet<Il> Il { get; set; }





    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}