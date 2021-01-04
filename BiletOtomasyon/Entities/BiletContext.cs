namespace BiletOtomasyon.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BiletContext : DbContext
    {
        public BiletContext()
            : base("name=BiletContext")
        {
        }

        public virtual DbSet<filminOturumlari> filminOturumlari { get; set; }
        public virtual DbSet<filmler> filmler { get; set; }
        public virtual DbSet<filmTarzi> filmTarzi { get; set; }
        public virtual DbSet<filmTurleri> filmTurleri { get; set; }
        public virtual DbSet<Koltuk> Koltuk { get; set; }
        public virtual DbSet<odemeSekli> odemeSekli { get; set; }
        public virtual DbSet<oturumlar> oturumlar { get; set; }
        public virtual DbSet<roleOfUsers> roleOfUsers { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<Salon> Salon { get; set; }
        public virtual DbSet<salonunKoltuklari> salonunKoltuklari { get; set; }
        public virtual DbSet<Satis> Satis { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<filmler>()
                .HasMany(e => e.filminOturumlari)
                .WithOptional(e => e.filmler)
                .HasForeignKey(e => e.filmId);

            modelBuilder.Entity<filmler>()
                .HasMany(e => e.Satis)
                .WithOptional(e => e.filmler)
                .HasForeignKey(e => e.filmID);

            modelBuilder.Entity<filmTurleri>()
                .HasMany(e => e.filmler)
                .WithRequired(e => e.filmTurleri)
                .HasForeignKey(e => e.FilmTurID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Koltuk>()
                .HasMany(e => e.salonunKoltuklari)
                .WithRequired(e => e.Koltuk)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<oturumlar>()
                .HasMany(e => e.filminOturumlari)
                .WithOptional(e => e.oturumlar)
                .HasForeignKey(e => e.oturumId);

            modelBuilder.Entity<roles>()
                .HasMany(e => e.roleOfUsers)
                .WithOptional(e => e.roles)
                .HasForeignKey(e => e.roleId);

            modelBuilder.Entity<Salon>()
                .HasMany(e => e.filmler)
                .WithOptional(e => e.Salon)
                .HasForeignKey(e => e.filmSalonID);

            modelBuilder.Entity<Salon>()
                .HasMany(e => e.salonunKoltuklari)
                .WithRequired(e => e.Salon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<salonunKoltuklari>()
                .HasMany(e => e.Satis)
                .WithOptional(e => e.salonunKoltuklari)
                .HasForeignKey(e => e.salonKoltukID);

            modelBuilder.Entity<users>()
                .HasMany(e => e.roleOfUsers)
                .WithOptional(e => e.users)
                .HasForeignKey(e => e.userId);
        }
    }
}
