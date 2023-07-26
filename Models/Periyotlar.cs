using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Periyotlar
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public string? Periyottur { get; set; }

    public DateTime? Songuncelleme { get; set; }

    public int? Gun { get; set; }
}
