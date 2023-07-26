using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Sepet
{
    public int Id { get; set; }

    public int? Kullaniciid { get; set; }

    public int? Stid { get; set; }

    public string Urunkod { get; set; } = null!;

    public string? Urunadi { get; set; }

    public decimal? Miktar { get; set; }

    public string? Birim { get; set; }

    public decimal? Birimfiyat { get; set; }

    public string? Kampanya { get; set; }

    public decimal? Toplamtutar { get; set; }

    public decimal? Kdv { get; set; }

    public decimal? Nettutar { get; set; }

    public decimal? Kdvtutari { get; set; }
}
