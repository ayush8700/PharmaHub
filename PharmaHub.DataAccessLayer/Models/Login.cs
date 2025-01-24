using System;
using System.Collections.Generic;

namespace PharmaHub.DataAccessLayer.Models;

public partial class Login
{
    public int LoginId { get; set; }

    public string EmailId { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public int? RoleId { get; set; }

    public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; } = new List<PurchaseDetail>();

    public virtual Role? Role { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
