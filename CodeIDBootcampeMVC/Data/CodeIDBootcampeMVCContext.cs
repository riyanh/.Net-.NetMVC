#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeIDBootcampeMVC.Models;

namespace CodeIDBootcampeMVC.Data
{
    public class CodeIDBootcampeMVCContext : DbContext
    {
        public CodeIDBootcampeMVCContext (DbContextOptions<CodeIDBootcampeMVCContext> options)
            : base(options)
        {
        }

        public DbSet<CodeIDBootcampeMVC.Models.Profile> Profile { get; set; }
    }
}
