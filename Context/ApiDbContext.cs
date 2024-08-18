using api_persons.Models;
using Microsoft.EntityFrameworkCore;

namespace api_persons.Context
{
    public class ApiDbContext: DbContext
    {   
        public ApiDbContext(DbContextOptions<ApiDbContext> options): base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}   