using System;
using System.Collections.Generic;
using System.Text;
using Course.Modeles;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Course.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Corb> Corbs { get; set; }

        public DbSet<Spare> Spares { get; set; }

        public DbSet<TypeSpare> TypeSpares { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
