using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCRUD
{
    public class PersonContext : DbContext  //oda kell írni
    {
        public DbSet<Person> Persons { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  //generate override --> dbcontext
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;database=Emberek;Trusted_Connection=True"); // ezt kell írni, classroomban,jegyzetben a Szerverkód
        }
    }
}
