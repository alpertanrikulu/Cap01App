using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Satistemsilcileri
{
    public int Id { get; set; }

    public int Distid { get; set; }

    public int Stref { get; set; }

    public string? Strefler { get; set; }

    public int Kullaniciid { get; set; }

    public string? Kodu { get; set; }

    public string? Adi { get; set; }

    public bool? Durum { get; set; }

    public int Period { get; set; }

    public string? Bolge { get; set; }

    public string? Gorev { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
