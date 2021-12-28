using Microsoft.EntityFrameworkCore;
using projectHotel;
using 
    System;
using System.Collections.Generic;
using System.Text;

namespace HotelProject
{
   public class Repo : DbContext
    {
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=hotel.db");
        }
       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Receptionist>().HasData(new Receptionist
            {
                ID = 1234,
                Name = "ahmed"
            });modelBuilder.Entity<Receptionist>().HasData(new Receptionist
            {
                ID = 2345,
                Name = "mona"
            });
            modelBuilder.Entity<Manager>().HasData(new Manager
            {
                ID = 4555,
                Name = "morad"

            });
            modelBuilder.Entity<Owner>().HasData(new Owner
            {
                ID = 1111,
                Name = "leyla"

            });
            modelBuilder.Entity<RoomType>().HasData(new RoomType
            {
                ID = 1,
                Type = "standard",
                Number_Of_Beds = 2,
                price_Per_Night = 30,
                Number_Of_Chairs = 0

            }) ;
            modelBuilder.Entity<RoomType>().HasData(new RoomType
            {
                ID = 2,
                Type = "sweet",
                Number_Of_Beds = 4,
                price_Per_Night = 60,
                Number_Of_Chairs = 0

            });
            modelBuilder.Entity<RoomType>().HasData(new RoomType
            {
                ID = 3,
                Type = "conference",
                Number_Of_Beds = 0,
                price_Per_Night = 50,
                Number_Of_Chairs = 25

            });
            modelBuilder.Entity<Room>().HasData(new Room
            {
                ID = 101,
                RoomTypeID = 1

            }) ;
            modelBuilder.Entity<Room>().HasData(new Room
            {
                ID = 102,
                RoomTypeID = 2

            });
            modelBuilder.Entity<Room>().HasData(new Room
            {     ID = 103,
                RoomTypeID = 3

            });
            modelBuilder.Entity<Room>().HasData(new Room
            {
                ID = 201,
                RoomTypeID = 1

            });
            modelBuilder.Entity<Room>().HasData(new Room
            {
                ID = 202,
                RoomTypeID = 2

            });
            modelBuilder.Entity<Room>().HasData(new Room
            {
                ID =203 ,
                RoomTypeID = 3

            });
            modelBuilder.Entity<Room>().HasData(new Room
            {
                ID = 303,
                RoomTypeID = 3

            });
            modelBuilder.Entity<Room>().HasData(new Room
            {
                ID = 301,
                RoomTypeID = 1

            });
            modelBuilder.Entity<Room>().HasData(new Room
            {
                ID = 302,
                RoomTypeID = 2

            });

        }
        public DbSet<Receptionist> receptionists { get; set; }
        public DbSet<Manager> managers { get; set; }
        public DbSet<client> clients { get; set; }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<RoomType> roomTypes { get; set; }
        public DbSet<Owner> owners{ get; set; }
       
    }
}
