using dropdown_mvc.Models;
using dropdownmvc.Models.cascande;
using Microsoft.EntityFrameworkCore;
namespace dropdownmvc.Models.Data
{
    public class ApplicationContect : DbContext
    {
        public ApplicationContect(DbContextOptions<ApplicationContect> options) :base(options)
        {

        }
        public DbSet<Country> countries { get; set; }
        public DbSet<State> states { get; set; }
        public DbSet<City> citys { get; set; }

        
    }
}
