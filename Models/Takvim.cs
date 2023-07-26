using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Takvim
{
    public int Id { get; set; }

    public int? Isyeriid { get; set; }

    public string? Baslik { get; set; }

    public DateTime? Baslangictarihi { get; set; }

    public DateTime? Bitistarihi { get; set; }

    public string? Renk { get; set; }

    public bool? Tumgun { get; set; }

    public string? Baslangictarihistr { get; set; }
}
