
using Microsoft.EntityFrameworkCore;
using NetCore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Data.Context
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions options) : base(options)
        {
             
        }

        public DbSet <Course> Courses { get; set; }
    }
}
