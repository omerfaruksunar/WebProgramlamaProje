using Microsoft.EntityFrameworkCore;
using Sahaf.Models;

namespace Sahaf.DataAccess
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
