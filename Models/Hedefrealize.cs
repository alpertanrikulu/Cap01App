using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Hedefrealize
{
    public int Id { get; set; }

    public int? Yil { get; set; }

    public int? Ay { get; set; }

    public int? Isyerid { get; set; }

    public int? Stid { get; set; }

    public string? Carikanal { get; set; }

    public string? Urunkategori { get; set; }

    public string? Baslik { get; set; }

    public decimal? Hedef { get; set; }

    public decimal? Gerceklesen { get; set; }

    public decimal? Oran { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
