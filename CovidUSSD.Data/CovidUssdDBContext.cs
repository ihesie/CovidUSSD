using CovidUSSD.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidUSSD.Data
{
   public class CovidUssdDBContext:DbContext
    {
        public CovidUssdDBContext(DbContextOptions dbContextOptions)
            :base(dbContextOptions)
        {

        }

        DbSet<MenuItem> menuItems { get; set; }

    }
}
