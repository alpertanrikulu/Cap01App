using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Stokraporu
{
    public long Id { get; set; }

    public short Ambarid { get; set; }

    public int Urunid { get; set; }

    public decimal Stok { get; set; }

    public decimal Satinalmafiyati { get; set; }

    public decimal Satisfiyati { get; set; }

    public DateTime Songuncelleme { get; set; }
}
