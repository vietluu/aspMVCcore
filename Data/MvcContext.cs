
using Microsoft.EntityFrameworkCore;


namespace MVC03.Data
{
    public class MvcContext : DbContext
    {
        public MvcContext (DbContextOptions<MvcContext> options)
            : base(options)
        {
        }
        

        public DbSet<MVC03.Models.Member> tblMember { get; set; } = default!;
    }
}
