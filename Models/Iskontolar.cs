using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Iskontolar
{
    public int Id { get; set; }

    public int Distid { get; set; }

    public int? Iskontoref { get; set; }

    public string? Iskstokkod { get; set; }

    public string? Iskcarikod { get; set; }

    public string? Isim { get; set; }

    public decimal? Yuzde { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
