using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class UrunbirimleriT
{
    public int Id { get; set; }

    public int Distid { get; set; }

    public int Itemref { get; set; }

    public int Birimref { get; set; }

    public decimal Cevrimkatsayi { get; set; }

    public bool? Anabirim { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
