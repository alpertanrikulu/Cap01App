using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Cariistatistik
{
    public int Id { get; set; }

    public int? Cariid { get; set; }

    public int? Isyeriid { get; set; }

    public int? Yil { get; set; }

    public int? Ay { get; set; }

    public string? Pskusatilanlar { get; set; }

    public int? Pskusayisitoplam { get; set; }

    public int? Pskusayisisatilan { get; set; }

    public decimal? Pskuoran { get; set; }

    public decimal? Bakiye { get; set; }

    public decimal? Gecikenbakiye { get; set; }

    public decimal? Guncelrisk { get; set; }

    public decimal? Risklimiti { get; set; }

    public decimal? Ciroix { get; set; }

    public decimal? Markaoran { get; set; }

    public int? Ziyaretortalamasure { get; set; }

    public byte Satisdurum { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
