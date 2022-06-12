using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OOAD2022.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOAD2022.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Dojmovi> Dojmovi { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Recenzija> Recenzija { get; set; }
        public DbSet<Rezervacija> Rezervacija { get; set; }
        public DbSet<Smjestaj> Smjestaj { get; set; }
        public DbSet<Soba> Soba { get; set; }
        public DbSet<Slike> Slike { get; set; }
        public DbSet<Uplata> Uplata { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Dojmovi>().ToTable("Dojmovi");
            builder.Entity<Korisnik>().ToTable("Korisnik");
            builder.Entity<Recenzija>().ToTable("Recenzija");
            builder.Entity<Rezervacija>().ToTable("Rezervacija");
            builder.Entity<Smjestaj>().ToTable("Smjestaj");
            builder.Entity<Soba>().ToTable("Soba");
            builder.Entity<Slike>().ToTable("Slike");
            builder.Entity<Uplata>().ToTable("Uplata");
            base.OnModelCreating(builder);
        }

    }
}
