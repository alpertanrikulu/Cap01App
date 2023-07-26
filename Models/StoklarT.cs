using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class StoklarT
{
    public int Id { get; set; }

    public int Distid { get; set; }

    public int Itemref { get; set; }

    public int? Ambarnr { get; set; }

    public decimal? Fiilistok { get; set; }

    public decimal? Gercekstok { get; set; }

    public DateTime Tarih { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
