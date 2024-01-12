using HomeWork34.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace HomeWork34.Dbdata
{
    public class RdmLevelSession : DbContext
    {
        //Buraya bir Constructors Oluşturuyorum
        public RdmLevelSession(DbContextOptions<RdmLevelSession> options) : base(options)
        {

        }

        //c# dbdeki tabloya ulasmak için bunu belirledim. 
        public DbSet<Customers> Customers { get; set; }

        
    }
}
