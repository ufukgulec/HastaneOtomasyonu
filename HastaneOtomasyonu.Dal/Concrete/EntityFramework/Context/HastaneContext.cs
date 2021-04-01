using HastaneOtomasyonu.Entities.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HastaneOtomasyonu.Dal.Concrete.EntityFramework.Context
{
    public partial class HastaneContext : DbContext
    {
        public HastaneContext()
            : base("name=HastaneContext")
        {
        }

        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Hospital> Hospital { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Policlinic> Policlinic { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
