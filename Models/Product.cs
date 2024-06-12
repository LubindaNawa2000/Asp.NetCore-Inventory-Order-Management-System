using System;
using System.Collections.Generic;

namespace Asp.NetCore_Inventory_Order_Management_System.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? Description { get; set; }

    public decimal UnitPrice { get; set; }

    public int QuantityInStock { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public int CategoryId { get; set; }

    public int SupplierId { get; set; }

    public int ReorderLevel { get; set; }

    public decimal? Weight { get; set; }

    public string? Dimensions { get; set; }

    public bool IsActive { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual Supplier Supplier { get; set; } = null!;
}
