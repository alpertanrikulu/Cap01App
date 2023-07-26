using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Kasalar
{
    public int Distid { get; set; }

    public int Kasaid { get; set; }

    public string? Kasakodu { get; set; }

    public string? Kasaadi { get; set; }

    public string Muhkodu { get; set; } = null!;

    public DateTime? Songuncelleme { get; set; }
}
