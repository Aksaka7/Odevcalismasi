using _10Odevcalismasi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace _10Odevcalismasi.DbData
{
    public class RdmLevelSession(DbContextOptions<RdmLevelSession> options) : DbContext(options)
    {

        //c# dbdeki tabloya ulasmak için bunu belirledim. 
        public DbSet<Customers> Customers { get; set; }
    }
}
