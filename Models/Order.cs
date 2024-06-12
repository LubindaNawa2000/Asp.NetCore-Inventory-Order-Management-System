using System;
using System.Collections.Generic;

namespace Asp.NetCore_Inventory_Order_Management_System.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public DateTime OrderDate { get; set; }

    public string ShipToAddress { get; set; } = null!;

    public string ShipToCity { get; set; } = null!;

    public string ShipToState { get; set; } = null!;

    public string ShipToCountry { get; set; } = null!;

    public string ShipToPostalCode { get; set; } = null!;

    public decimal TotalAmount { get; set; }

    public string Status { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
}
