using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEF.Models;

namespace WindowsEF.Data
{
    public class DBClinicaEFContext : DbContext
    {
        public DBClinicaEFContext() : base("KeyDB") { }

        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }

    }
}
