using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Liderpanosu
{
    public int Id { get; set; }

    public int? Yil { get; set; }

    public int? Ay { get; set; }

    public int? Isyeriid { get; set; }

    public int? Stid { get; set; }

    public string? Stkodu { get; set; }

    public string? Stadi { get; set; }

    public int? Sira { get; set; }

    public byte? Rozet { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
