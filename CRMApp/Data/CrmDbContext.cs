using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using CRMApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CRMApp.Data
{
    public class CrmDbContext : IdentityDbContext
    {
        public DbSet<ManagerEntity> Managers { get; set; }
        public string DbPath { get; set; } = string.Empty;

        public CrmDbContext()
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "ThAmCo.CRM.db");
            //Console.WriteLine($"Database Path: {DbPath}"); //Debugging
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
    }
}


        