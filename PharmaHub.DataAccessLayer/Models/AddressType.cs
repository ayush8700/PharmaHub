using System;
using System.Collections.Generic;

namespace PharmaHub.DataAccessLayer.Models;

public partial class AddressType
{
    public int AddressTypeId { get; set; }

    public string AddressTypeName { get; set; } = null!;

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
}
