using Microsoft.EntityFrameworkCore;
using webapi.Model;

namespace webapi.Repository
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public PersonContext(DbContextOptions<PersonContext> options) : base(options)
        {
            
        }
    }
}
