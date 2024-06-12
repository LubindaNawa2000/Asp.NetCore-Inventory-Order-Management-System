using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp.NetCore_Inventory_Order_Management_System.Models;

    public class WarehouseDBContext : DbContext
    {
        public WarehouseDBContext (DbContextOptions<WarehouseDBContext> options)
            : base(options)
        {
        }

        public DbSet<Asp.NetCore_Inventory_Order_Management_System.Models.Product> Product { get; set; } = default!;

public DbSet<Asp.NetCore_Inventory_Order_Management_System.Models.Category> Category { get; set; } = default!;

public DbSet<Asp.NetCore_Inventory_Order_Management_System.Models.Customer> Customer { get; set; } = default!;

public DbSet<Asp.NetCore_Inventory_Order_Management_System.Models.Shipment> Shipment { get; set; } = default!;

public DbSet<Asp.NetCore_Inventory_Order_Management_System.Models.Order> Order { get; set; } = default!;

public DbSet<Asp.NetCore_Inventory_Order_Management_System.Models.WarehouseLocation> WarehouseLocation { get; set; } = default!;

public DbSet<Asp.NetCore_Inventory_Order_Management_System.Models.Inventory> Inventory { get; set; } = default!;

public DbSet<Asp.NetCore_Inventory_Order_Management_System.Models.Purchase> Purchase { get; set; } = default!;

public DbSet<Asp.NetCore_Inventory_Order_Management_System.Models.Supplier> Supplier { get; set; } = default!;
    }
