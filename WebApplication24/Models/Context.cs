using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication24.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options)
        {

        }
        public DbSet<Rolemaster> Rolemasters { get; set; }
    }
}
