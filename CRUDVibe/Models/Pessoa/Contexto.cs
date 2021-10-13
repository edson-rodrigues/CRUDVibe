using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data.Entity;
using CRUDVibe.Models.Endereços;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDVibe.Models
{
    public class Contexto : DbContext
    {
        public virtual DbSet<Pessoa> Pessoas { get; set; }
        public virtual DbSet<Endereco> Enderecos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer<Contexto>(null);
            modelBuilder.Entity<Pessoa>()
                .HasOptional(s => s.endereco) // Mark Address property optional in Student entity
                .WithRequired(ad => ad.pessoa) // mark Student property as required in StudentAddress entity. Cannot save StudentAddress without Student
                .WillCascadeOnDelete(true);
        }
    }
   
}