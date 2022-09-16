using EducationCenter.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EducationCenter.Data.DbContexts
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>().HasData(
                new Position()
                {
                    Id = 1,
                    Name = "Teacher",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Status = Domain.Enums.PositionStatus.Active
                });
        }
    }
}