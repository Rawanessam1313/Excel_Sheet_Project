using Excel.Data_Access_layer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel.Data_Access_layer.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(
                "Server=.;Database=ExcelData;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true",
                sqlOptions => sqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null));
    

        }
        public DbSet<Excel_Data> ExcelData { get; set; }  
    }
}
