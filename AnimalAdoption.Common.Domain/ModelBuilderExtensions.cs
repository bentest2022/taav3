using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption.Common.Domain
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>().HasData(
                new Owner { Id = 1, Name = "Bob Smith", PhoneNumber = "021578526", Address = "34 Silverdale Road" },
                new Owner { Id = 2, Name = "Wayne Johnson", PhoneNumber = "027859645", Address = "158 Hamilton Road" },
                new Owner { Id = 3, Name = "Jane Doe", PhoneNumber = "0214570876", Address = "2A River Road" }
            );

            modelBuilder.Entity<Animal>().HasData(
                new Animal { Id = 1, Name = "Lucy", Age = 1, Description = "Golden retriever. Female", OwnerId = 1 },
                new Animal { Id = 2, Name = "Gizmo", Age = 4, Description = "Pug. Male", OwnerId = 2 },
                new Animal { Id = 3, Name = "Freddy", Age = 7, Description = "German Shepard. Male", OwnerId = 3 }
            );
        }
    }
}
