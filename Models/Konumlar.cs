using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Konumlar
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public int? Kullaniciid { get; set; }

    public decimal? Lat { get; set; }

    public decimal? Lng { get; set; }

    public DateTime? Tarih { get; set; }

    public int? Islemturuid { get; set; }

    public int? Islemid { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
