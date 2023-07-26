using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Stoklar
{
    public int Id { get; set; }

    public byte? Distid { get; set; }

    public int Itemref { get; set; }

    public short? Ambarref { get; set; }

    public byte? Ambarnr { get; set; }

    public decimal? Fiilistok { get; set; }

    public decimal? Gercekstok { get; set; }

    public DateTime Tarih { get; set; }

    public DateTime Songuncelleme { get; set; }
}
