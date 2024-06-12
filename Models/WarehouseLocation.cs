using System;
using System.Collections.Generic;

namespace Asp.NetCore_Inventory_Order_Management_System.Models;

public partial class WarehouseLocation
{
    public int WarehouseLocationId { get; set; }

    public string LocationName { get; set; } = null!;

    public string? Aisle { get; set; }

    public string? Shelf { get; set; }

    public string? Bin { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
}
