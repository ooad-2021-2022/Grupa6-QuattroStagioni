using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SanZan.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanZan.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BezgotovinskaUplata> BezgotovinskaUplata { get; set; }
        public DbSet<DjelatnikTagovi> DjelatnikTagovi { get; set; }
        public DbSet<GotovinskaUplata> GotovinskaUplata { get; set; }
        public DbSet<InfoPitanje> InfoPitanje { get; set; }
        public DbSet<Kartica> Kartica { get; set; }
        public DbSet<KonkretniStatus> KonkretniStatus { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Lokacija> Lokacija { get; set; }
        public DbSet<ModeratorOglasi> ModeratorOglasi { get; set; }
        public DbSet<Oglas> Oglas { get; set; }
        public DbSet<Poruka> Poruka { get; set; }
        public DbSet<Prijava> Prijava { get; set; }
        public DbSet<Recenzija> Recenzija { get; set; }
        public DbSet<Statistika> Statistika { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Zahtjev> Zahtjev { get; set; }
        public DbSet<ZahtjevTagovi> ZahtjevTagovi { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<BezgotovinskaUplata>().ToTable("BezgotovinskaUplate");
            modelBuilder.Entity<DjelatnikTagovi>().ToTable("DjelatnikTagovi");
            modelBuilder.Entity<GotovinskaUplata>().ToTable("GotovinskaUplata");
            modelBuilder.Entity<InfoPitanje>().ToTable("InfoPitanje");
            modelBuilder.Entity<Kartica>().ToTable("Kartica");
            modelBuilder.Entity<KonkretniStatus>().ToTable("KonkretniStatus");
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Lokacija>().ToTable("Lokacija");
            modelBuilder.Entity<ModeratorOglasi>().ToTable("ModeratorOglasi");
            modelBuilder.Entity<Oglas>().ToTable("Oglas");
            modelBuilder.Entity<Poruka>().ToTable("Poruka");
            modelBuilder.Entity<Prijava>().ToTable("Prijava");
            modelBuilder.Entity<Recenzija>().ToTable("Recenzija");
            modelBuilder.Entity<Statistika>().ToTable("Statistika");
            modelBuilder.Entity<Tag>().ToTable("Tag");
            modelBuilder.Entity<Zahtjev>().ToTable("Zahtjev");
            modelBuilder.Entity<ZahtjevTagovi>().ToTable("ZahtjevTagovi");
            base.OnModelCreating(modelBuilder);
        }
    }
}
