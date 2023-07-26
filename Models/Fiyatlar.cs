using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Fiyatlar
{
    public int Id { get; set; }

    public byte? Distid { get; set; }

    public int? Itemref { get; set; }

    public byte? Ftip { get; set; }

    public DateTime? Bastarih { get; set; }

    public DateTime? Bittarih { get; set; }

    public string? Grupkodu { get; set; }

    public short? Oncelik { get; set; }

    public string Carikod { get; set; } = null!;

    public string Caritig { get; set; } = null!;

    public string Cariyetkikodu { get; set; } = null!;

    public string Cariozelkod1 { get; set; } = null!;

    public string Cariozelkod2 { get; set; } = null!;

    public string Cariozelkod3 { get; set; } = null!;

    public string Cariozelkod4 { get; set; } = null!;

    public string Cariozelkod5 { get; set; } = null!;

    public decimal? Fiyat { get; set; }

    public short? Dovizid { get; set; }

    public decimal? Carpan { get; set; }

    public int? Birimref { get; set; }

    public bool? Kdvdahil { get; set; }

    public int? Odemeplanref { get; set; }

    public DateTime? Kayittarihi { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
