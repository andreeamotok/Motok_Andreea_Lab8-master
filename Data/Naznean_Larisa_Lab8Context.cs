using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Motok_Andreea_Lab8.Models;

namespace Motok_Andreea_Lab8.Data
{
    public class Motok_Andreea_Lab8Context : DbContext
    {
        public Motok_Andreea_Lab8Context (DbContextOptions<Motok_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Motok_Andreea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Motok_Andreea_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Motok_Andreea_Lab8.Models.Category> Category { get; set; }
    }
}
