﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HouseRentingSystem.Data.Entities;
using Microsoft.AspNetCore.Identity;
using static Humanizer.In;
using System.Net;

namespace HouseRentingSystem.Data
{
    public class HouseRentingDbContext : IdentityDbContext
    {
        public IdentityUser AgentUser { get; set; }
        public IdentityUser GuestUser { get; set; }
        public Agent Agent { get; set; }
        public Category CottageCategory { get; set; }
        public Category SingleCategory { get; set; }
        public Category DuplexCategory { get; set; }
        public House FirstHouse { get; set; }
        public House SecondHouse { get; set; }
        public House ThirdHouse { get; set; }

        public DbSet<House> Houses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Agent> Agents { get; set; }
        
        public HouseRentingDbContext(DbContextOptions<HouseRentingDbContext> options)
            : base(options)
        {
            this.Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<House>()
                .HasOne(h => h.Category)
                .WithMany(c => c.Houses)
                .HasForeignKey(h => h.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<House>()
                .HasOne(h => h.Agent)
                .WithMany()
                .HasForeignKey(h => h.AgentId)
                .OnDelete(DeleteBehavior.Restrict);

            SeedUsers();
            builder.Entity<IdentityUser>()
                .HasData(this.Agent);

            SeedAgent();
            builder.Entity<Agent>()
                .HasData(this.Agent);

            SeedCategories();
            builder.Entity<Category>()
                .HasData(this.CottageCategory, this.SingleCategory);

            SeedHouses();
            builder.Entity<House>()
                .HasData(this.FirstHouse, this.SecondHouse, this.ThirdHouse);

            base.OnModelCreating(builder);
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();
            this.AgentUser = new IdentityUser()
            {
                Id = "qwerty1",
                UserName = "agent@mail.com",
                NormalizedUserName = "agent@mail.com",
                Email = "agent@mail.com",
                NormalizedEmail = "agent@mail.com"
            };

            this.AgentUser.PasswordHash = hasher.HashPassword(this.AgentUser, "agent123");

            this.GuestUser = new IdentityUser()
            {
                Id = "qwerty2",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };

            this.GuestUser.PasswordHash = hasher.HashPassword(this.GuestUser, "guest123");
        }

        private void SeedAgent()
        {
            this.Agent = new Agent()
            {
                Id = 1,
                UserId = this.AgentUser.Id,
                PhoneNumber = "+35988888888"
            };
        }

        private void SeedCategories()
        {
            this.CottageCategory = new Category()
            {
                Id = 1,
                Name = "Cottage"
            };

            this.SingleCategory = new Category()
            {
                Id = 2,
                Name = "Single"
            };

            this.DuplexCategory = new Category()
            {
                Id = 3,
                Name = "Duplex"
            };
        }

        private void SeedHouses()
        {
            this.FirstHouse = new House()
            {
                Id = 1,
                Title = "Big House Marina",
                Address = "North London, UK (near the border)",
                Description = "A big house for your whole family. Don't miss to buy a house with three bedrooms.",
                ImageUrl = "https://www.luxury-architecture.net/wp-content/uploads/2017/12/1513217889-7597-FAIRWAYS - 010.jpg",
                PricePerMonth = 2100.00M,
                CategoryId = this.DuplexCategory.Id,
                AgentId = this.Agent.Id,
                RenterId = this.GuestUser.Id
            };
            this.SecondHouse = new House()
            {
                Id = 2,
                Title = "Family House Comfort",
                Address = "Near the Sea Garden in Burgas, Bulgaria",
                Description = "It has the best comfort you will ever ask for. With two bedrooms, it is great for your family.",
                ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/179489660.jpg" + "?k=2029f6d9589b49c95dcc9503a265e292c2cdfcb5277487a0050397c3f8dd545a&o=&hp=1",
                PricePerMonth = 1200.00M,
                CategoryId = this.SingleCategory.Id,
                AgentId = this.Agent.Id
            };
            
            this.ThirdHouse = new House()
            {
                Id = 3,
                Title = "Grand House",
                Address = "Boyana Neighbourhood, Sofia, Bulgaria",
                Description = "This luxurious house is everything you will need. It is just excellent.",
                ImageUrl = "https://i.pinimg.com/originals/a6/f5/85/a6f5850a77633c56e4e4ac4f867e3c00.jpg",
                PricePerMonth = 2000.00M,
                CategoryId = this.SingleCategory.Id,
                AgentId = this.Agent.Id
            };
        }
    }
}