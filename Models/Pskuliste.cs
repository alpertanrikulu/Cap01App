using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Pskuliste
{
    public int Id { get; set; }

    public string? Adi { get; set; }

    public string? Urunkodu { get; set; }

    public string? Urunyetkikodu { get; set; }

    public string? Carikanal { get; set; }

    public int? Isyeriid { get; set; }

    public int? Periyot { get; set; }

    public int? Baslangicay { get; set; }

    public int? Baslangicyil { get; set; }

    public DateTime? Baslangictarihi { get; set; }

    public DateTime? Bitistarihi { get; set; }

    public int? Kullaniciid { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
