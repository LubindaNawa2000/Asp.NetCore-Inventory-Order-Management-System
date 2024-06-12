using System;
using System.Collections.Generic;

namespace Asp.NetCore_Inventory_Order_Management_System.Models;

public partial class Shipment
{
    public int ShipmentId { get; set; }

    public int OrderId { get; set; }

    public DateTime ShipmentDate { get; set; }

    public string? TrackingNumber { get; set; }

    public string? CarrierName { get; set; }

    public string Status { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
