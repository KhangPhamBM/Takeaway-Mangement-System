using System;
using System.Collections.Generic;

namespace SnackDeliveryLibrary.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime? OrderDate { get; set; }

    public int? StaffId { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
