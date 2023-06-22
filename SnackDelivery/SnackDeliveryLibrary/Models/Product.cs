using System;
using System.Collections.Generic;

namespace SnackDeliveryLibrary.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public double? Price { get; set; }

    public double? Discount { get; set; }

    public bool? Deleted { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
