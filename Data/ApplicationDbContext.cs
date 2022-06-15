using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TuristickaAgencija.Models;

namespace TuristickaAgencija.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Administrator> Administrator { get; set; }
       // public DbSet<ErrorViewModel> ErrorViewModel{ get; set; }
        public DbSet<Lokacija> Lokacija { get; set; }
        public DbSet<Notifikacija> Notifikacija { get; set; }
        public DbSet<Ocjena> Ocjena { get; set; }
        public DbSet<Prijevoznik> Prijevoznik { get; set; }
        public DbSet<PutnaLinija> PutnaLinija { get; set; }
        public DbSet<Putnik> Putnik { get; set; }
        public DbSet<Rezervacija> Rezetvacija { get; set; }
        public DbSet<Smjestaj> Smjestaj { get; set; }

        public DbSet<Soba> Soba { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Usluga> Usluga { get; set; }
        public DbSet<UslugaPrijevoza> UslugaPrijevoza { get; set; }
        public DbSet<UslugaSmjestaja> UslugaSmjestaja { get; set; }
        public DbSet<VlasnikSmjestaja> VlasnikSmjestaja { get; set; }
        public DbSet<Vozilo> Vozilo { get; set; }
        public DbSet<ZahtjevZaBrisanjem> ZahtjevZaBrisanjem{ get; set; }
        public DbSet<Zaposlenik> Zaposlenik { get; set; }
        public DbSet<Putnik_Usluga> Putnik_Usluga { get; set; }
        public DbSet<Rezervacija_Usluga> Rezervacija_Usluga { get; set; }
        public DbSet<Slika> Slika { get; set; }
        public DbSet<PutnaLinija_Lokacija> PutnaLinija_Lokacija { get; set; }
        public DbSet<Sjediste> Sjediste { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>().ToTable("Administrator");
           // modelBuilder.Entity<ErrorViewModel>().ToTable("ErrorViewModel");
            modelBuilder.Entity<Lokacija>().ToTable("Lokacija");
            modelBuilder.Entity<Notifikacija>().ToTable("Notifikacija");
            modelBuilder.Entity<Ocjena>().ToTable("Ocjena");
            modelBuilder.Entity<Prijevoznik>().ToTable("Prijevoznik");
            modelBuilder.Entity<PutnaLinija>().ToTable("PutnaLinija");
            modelBuilder.Entity<Putnik>().ToTable("Putnik");
            modelBuilder.Entity<Rezervacija>().ToTable("Rezervacija");
            modelBuilder.Entity<Smjestaj>().ToTable("Smjestaj");
            modelBuilder.Entity<Soba>().ToTable("Soba");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Usluga>().ToTable("Usluga");
            modelBuilder.Entity<UslugaPrijevoza>().ToTable("UslugaPrijevoza");
            modelBuilder.Entity<UslugaSmjestaja>().ToTable("UslugaSmjestaja");
            modelBuilder.Entity<VlasnikSmjestaja>().ToTable("VlasnikSmjestaja");
            modelBuilder.Entity<Vozilo>().ToTable("Vozilo");
            modelBuilder.Entity<ZahtjevZaBrisanjem>().ToTable("ZahtjevZaBrisanjem");
            modelBuilder.Entity<Zaposlenik>().ToTable("Zaposlenik");

            modelBuilder.Entity<Putnik_Usluga>().ToTable("Putnik_Usluga");
            modelBuilder.Entity<Rezervacija_Usluga>().ToTable("Rezervacija_Usluga");
            modelBuilder.Entity<Slika>().ToTable("Slika");
            modelBuilder.Entity<PutnaLinija_Lokacija>().ToTable("PutnaLinija_Lokacija");
            modelBuilder.Entity<Sjediste>().ToTable("Sjediste");
            base.OnModelCreating(modelBuilder);
        }

    }
}
