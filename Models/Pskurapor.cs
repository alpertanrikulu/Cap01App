using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Pskurapor
{
    public int Id { get; set; }

    public int? Yil { get; set; }

    public int? Ay { get; set; }

    public int? Bperiod { get; set; }

    public int? Rperiod { get; set; }

    public int? Stid { get; set; }

    public string? Stadi { get; set; }

    public int? Isyeriid { get; set; }

    public int? Cariid { get; set; }

    public string? Cariunvani { get; set; }

    public string? Carikodu { get; set; }

    public string? Urunkodu { get; set; }

    public string? Urunyetkikodu { get; set; }

    public string? Urunadi { get; set; }

    public int? Kanal { get; set; }

    public bool? Durum { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
