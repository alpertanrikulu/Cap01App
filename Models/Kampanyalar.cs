using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Kampanyalar
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public int? Isyeriid { get; set; }

    public string? Kod { get; set; }

    public string? Ad { get; set; }

    public string? Aciklama { get; set; }

    public int? Oncelik { get; set; }

    public bool? Aktif { get; set; }

    public string? Kisaad { get; set; }

    public decimal? Tutarlimit { get; set; }

    public int? Limitdovizid { get; set; }

    public DateTime? Songuncelleme { get; set; }

    public string? Guncelleyenkullanici { get; set; }
}
