using System;
using System.Collections.Generic;

namespace Asp.NetCore_Inventory_Order_Management_System.Models;

public partial class Inventory
{
    public int InventoryId { get; set; }

    public int ProductId { get; set; }

    public int WarehouseLocationId { get; set; }

    public int Quantity { get; set; }

    public DateTime LastUpdatedDate { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual WarehouseLocation WarehouseLocation { get; set; } = null!;
}
