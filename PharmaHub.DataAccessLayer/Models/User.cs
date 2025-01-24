using System;
using System.Collections.Generic;

namespace PharmaHub.DataAccessLayer.Models;

public partial class User
{
    public int UserId { get; set; }

    public int? LoginId { get; set; }

    public string FirstName { get; set; } = null!;

    public string SecondName { get; set; } = null!;

    public string? Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual Login? Login { get; set; }
}
