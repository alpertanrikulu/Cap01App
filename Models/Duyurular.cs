using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Duyurular
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public int? Isyeriid { get; set; }

    public DateTime? Bastarih { get; set; }

    public DateTime? Bittarih { get; set; }

    public string? Baslik { get; set; }

    public string? Duyuru { get; set; }

    public string? Kullaniciid { get; set; }

    public DateTime? Kayittarihi { get; set; }

    public string? Okuyanstler { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
