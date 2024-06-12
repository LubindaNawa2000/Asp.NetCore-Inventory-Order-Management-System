using System;
using System.Collections.Generic;

namespace Asp.NetCore_Inventory_Order_Management_System.Models;

public partial class Purchase
{
    public int PurchaseId { get; set; }

    public DateTime PurchaseDate { get; set; }

    public int SupplierId { get; set; }

    public decimal TotalAmount { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? ExpectedDeliveryDate { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public DateTime? PaymentDueDate { get; set; }

    public DateTime? PaidDate { get; set; }

    public string? Notes { get; set; }

    public virtual Supplier Supplier { get; set; } = null!;
}
