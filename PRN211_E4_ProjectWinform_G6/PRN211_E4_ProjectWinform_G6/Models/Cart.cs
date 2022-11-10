using System;
using System.Collections.Generic;

namespace PRN211_E4_ProjectWinform_G6.Models;

public partial class Cart
{
    public int Id { get; set; }

    public string? CartId { get; set; }

    public int? ProductId { get; set; }

    public int Count { get; set; }

    public DateTime? DateCreate { get; set; }

    public virtual Product? Product { get; set; }
}
