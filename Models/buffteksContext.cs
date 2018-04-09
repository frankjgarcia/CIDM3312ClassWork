using Microsoft.EntityFrameworkCore;

namespace MainFinal.Models
{
    public class BufftecksContext : DbContext
    {
        public BufftecksContext (DbContextOptions<BufftecksContext> options)
        : base (options)
        {

        }

        public DbSet <MainFinal.Models.Member> Member {get; set;}
    }
}