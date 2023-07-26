using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class FiyatlarT
{
    public int Distid { get; set; }

    public int Itemref { get; set; }

    public int Ftip { get; set; }

    public DateTime Bastarih { get; set; }

    public DateTime Bittarih { get; set; }

    public int Oncelik { get; set; }

    public string? Carikod { get; set; }

    public string? Caritig { get; set; }

    public string? Cariyetkikodu { get; set; }

    public string? Cariozelkod1 { get; set; }

    public string? Cariozelkod2 { get; set; }

    public string? Cariozelkod3 { get; set; }

    public string? Cariozelkod4 { get; set; }

    public string? Cariozelkod5 { get; set; }

    public decimal Fiyat { get; set; }

    public decimal? Carpan { get; set; }

    public DateTime Kayittarihi { get; set; }

    public int Id { get; set; }

    public int? Dovizid { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
