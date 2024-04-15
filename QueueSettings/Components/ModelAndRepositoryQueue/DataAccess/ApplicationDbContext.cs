using Microsoft.EntityFrameworkCore;

namespace BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<QueueEmployeeSettings> queueEmployeeSettings { get; set; }


    }
}
