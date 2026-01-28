using System;
using System.Collections.Generic;

namespace store.Models;

public partial class Test
{
    public string Id { get; set; } = null!;

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public decimal? Salary { get; set; }
}
