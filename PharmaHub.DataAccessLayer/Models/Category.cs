using System;
using System.Collections.Generic;

namespace PharmaHub.DataAccessLayer.Models;

public partial class Category
{
    public byte CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
