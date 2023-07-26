using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Hedefler
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public int? Isyeriid { get; set; }

    public string? Urunkategoriid { get; set; }

    public string? Kanal { get; set; }

    public int? Stid { get; set; }

    public string? StKodu { get; set; }

    public int? Kullaniciid { get; set; }

    public int? Hedeftipiid { get; set; }

    public int? Yil { get; set; }

    public int? Ay { get; set; }

    public int? Ceyrek { get; set; }

    public int? Yarim { get; set; }

    public DateTime? Kayittarihi { get; set; }

    public DateTime? Sonislemtarihi { get; set; }

    public decimal? Hedef { get; set; }

    public int? Dovizid { get; set; }

    public decimal? Hedefmiktar { get; set; }

    public int? Birimid { get; set; }

    public int? Periyodid { get; set; }

    public DateTime? Songuncelleme { get; set; }

    public decimal? Hedeftutar { get; set; }
}
