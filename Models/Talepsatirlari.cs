using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Talepsatirlari
{
    public int Id { get; set; }

    public int? Talepid { get; set; }

    public int? Urunid { get; set; }

    public decimal? Miktar { get; set; }

    public int? Birimid { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
