using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Puscas_Andrei_Ioan_Laborator2.Models;

namespace Puscas_Andrei_Ioan_Laborator2.Data
{
    public class Puscas_Andrei_Ioan_Laborator2Context : DbContext
    {
        public Puscas_Andrei_Ioan_Laborator2Context (DbContextOptions<Puscas_Andrei_Ioan_Laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Puscas_Andrei_Ioan_Laborator2.Models.Book> Book { get; set; } = default!;

        public DbSet<Puscas_Andrei_Ioan_Laborator2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Puscas_Andrei_Ioan_Laborator2.Models.Authors>? Authors { get; set; }
    }
}
