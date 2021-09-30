using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using colour.Models;

    public class colourContext : DbContext
    {
        public colourContext (DbContextOptions<colourContext> options)
            : base(options)
        {
        }

        public DbSet<colour.Models.Program1> Program1 { get; set; }
    }
