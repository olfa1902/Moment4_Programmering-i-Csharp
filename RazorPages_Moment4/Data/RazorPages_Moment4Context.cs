using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPages_Moment4.Models;

namespace RazorPages_Moment4.Data
{
    public class RazorPages_Moment4Context : DbContext
    {
        public RazorPages_Moment4Context (DbContextOptions<RazorPages_Moment4Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPages_Moment4.Models.Movie> Movie { get; set; }
    }
}
