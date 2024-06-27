using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugInvortoryDesktop.Models
{
    
        public class PlanteContext : DbContext
        {
            public PlanteContext() 
            {
                
            }
            // comment definir les tables
            public DbSet<plantule> plantule { get; set; }
            public DbSet<plantule> archive { get; set; }



        // defintion de la connexion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

                => optionsBuilder.UseSqlServer("Data Source=LAPTOP-796E5764\\SQLEXPRESS;Initial Catalog=Canabis;Integrated Security=True;Encrypt=False");

            //"Data Source = DAVIDIL-LAPTOP-\\SQLEXPRESS01;Initial Catalog=Canabis; Integrated Security=True; Encrypt=False"
        }
    
}
