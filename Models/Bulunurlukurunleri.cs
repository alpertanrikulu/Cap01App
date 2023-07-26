using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Bulunurlukurunleri
{
    public int Id { get; set; }

    public int? Sinifid { get; set; }

    public string? Urunkodu { get; set; }

    public string? Urunadi { get; set; }

    public string? Marka { get; set; }

    public string? Firma { get; set; }

    public int? Kullaniciid { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
