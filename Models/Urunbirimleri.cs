using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Urunbirimleri
{
    public int Id { get; set; }

    public byte? Distid { get; set; }

    public int? Itemref { get; set; }

    public short? Birimref { get; set; }

    public decimal? Cevrimkatsayi { get; set; }

    public bool? Anabirim { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
