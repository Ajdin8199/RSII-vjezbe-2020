using eProdaja.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Models
{
    public partial class eProdajaContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JediniceMjere>().HasData(new eProdaja.Models.JediniceMjere()
            {
                JedinicaMjereId = 1,
                Naziv = "Test"
            });
        }

    }
}
