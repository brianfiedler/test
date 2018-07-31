﻿using Microsoft.AspNetCore.JsonPatch.Operations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace WebApplication1.DataAccess
{
    public class AutoRepairContext : DbContext
    {

        public AutoRepairContext() 
        {
            
        }

        //public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Automobile> Automobiles { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }
        public virtual DbSet<Motorcycle> Motorcycles { get; set; }
        public virtual DbSet<Plan> Plans  { get; set; }
        public virtual DbSet<Tuner> Tuners { get; set; }
        public virtual DbSet<Dragcar> Dragcars { get; set; }
        public virtual DbSet<PerformanceAuto> PerformanceAutos { get; set; }

    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AutoRepair;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Vehicle>().HasKey(c => c.Identifier);
            //modelBuilder.Entity<Automobile>().HasKey(c => c.Id);
            //modelBuilder.Entity<Customer>().HasKey(c => c.Id);
            //modelBuilder.Entity<Motorcycle>().HasKey(c => c.Id);
            //modelBuilder.Entity<WorkOrder>().HasKey(c => c.Id);
            //modleBuilder.Entity<Plan>().HasKey(c => c.Id);
            //modleBuilder.Entity<Tuner>().HasKey(c => c.Id);
            modelBuilder.Ignore<Vehicle>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
