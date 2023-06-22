using System;
using System.Collections.Generic;

namespace SnackDeliveryLibrary.Models;

public partial class Account
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Password { get; set; }

    public string? PhoneNumber { get; set; }

    public bool? IsAdmin { get; set; }

    public bool? Deleted { get; set; }
}
