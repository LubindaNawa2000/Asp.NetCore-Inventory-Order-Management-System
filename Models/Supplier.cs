using System;
using System.Collections.Generic;

namespace Asp.NetCore_Inventory_Order_Management_System.Models;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string SupplierName { get; set; } = null!;

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? PostalCode { get; set; }

    public string? ContactName { get; set; }

    public string? Phone { get; set; }

    public string Email { get; set; } = null!;

    public string? Website { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
}
