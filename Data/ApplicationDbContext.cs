using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectCalidadSoft.Models;

namespace ProjectCalidadSoft.Data
{

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<ContactoFamiliar> ContactoFamiliar { get; set; }
        public virtual DbSet<DiagnosticoMedico> DiagnosticoMedico { get; set; }
        public virtual DbSet<Cie10> Cie10{ get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiagnosticoMedico>().HasKey(s => new { s.IdCie10, s.IdPaciente });

            modelBuilder.Entity<DiagnosticoMedico>()
             .HasOne(sc => sc.Cie10)
             .WithMany(s => s.DiagnosticoMedico)
             .HasForeignKey(sc => sc.IdCie10);

            modelBuilder.Entity<DiagnosticoMedico>()
                .HasOne(sc => sc.Paciente)
                .WithMany(c => c.DiagnosticoMedico)
                .HasForeignKey(sc => sc.IdPaciente);


            /*
              base.OnModelCreating(modelBuilder);
              modelBuilder.Entity<DiagnosticoMedico>()
              .HasNoKey();
              */
        }
    }
}
