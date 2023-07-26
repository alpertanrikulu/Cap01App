using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Bulunurlukolcum
{
    public int Id { get; set; }

    public int? Urunid { get; set; }

    public int? Cariid { get; set; }

    public int? Sevkid { get; set; }

    public int? Ziyaretid { get; set; }

    public string? Ziyaretuid { get; set; }

    public int? Stid { get; set; }

    public DateTime? Tarih { get; set; }

    public bool? Bulunurluk { get; set; }

    public decimal? Rafpayi { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
