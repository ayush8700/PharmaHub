using System;
using System.Collections.Generic;

namespace PharmaHub.DataAccessLayer.Models;

public partial class Address
{
    public int AddressId { get; set; }

    public int? UserId { get; set; }

    public int? AddressTypeId { get; set; }

    public string MobileNo { get; set; } = null!;

    public string? AlternateMobileNo { get; set; }

    public string Address1 { get; set; } = null!;

    public string Town { get; set; } = null!;

    public string Pincode { get; set; } = null!;

    public int? StateId { get; set; }

    public int? CountryId { get; set; }

    public virtual AddressType? AddressType { get; set; }

    public virtual Country? Country { get; set; }

    public virtual State? State { get; set; }

    public virtual User? User { get; set; }
}
