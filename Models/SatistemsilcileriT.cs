using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class SatistemsilcileriT
{
    public int Id { get; set; }

    public int Distid { get; set; }

    public int Stref { get; set; }

    public string? Kodu { get; set; }

    public string? Adi { get; set; }

    public int? Period { get; set; }

    public string? Bolge { get; set; }

    public string? Gorev { get; set; }

    public int? Kullaniciid { get; set; }

    public DateTime? Songuncelleme { get; set; }

    public DateTime? Strutsonislem { get; set; }

    public DateTime? Strutsonguncelleme { get; set; }

    public string? Soneklenenstrutgun { get; set; }

    public bool? Excelrotaguncelleme { get; set; }

    public DateTime? Strutguncellemebaslangic { get; set; }

    public string? Strefler { get; set; }

    public bool? Durum { get; set; }

    public DateTime? Strutguncellemehafta { get; set; }

    public string? Yaziciismi { get; set; }

    public string? Kasalar { get; set; }

    public bool? Dashgorunurluk { get; set; }

    public bool? Isbusy { get; set; }

    public string? Isyerleri { get; set; }
}
