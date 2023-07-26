using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Sanalasistan
{
    public int Id { get; set; }

    public int? Isyeriid { get; set; }

    public int? Stid { get; set; }

    public string? Baslik { get; set; }

    public string? Detay { get; set; }

    public string? Image { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
