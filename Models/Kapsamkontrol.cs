using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Kapsamkontrol
{
    public int Id { get; set; }

    public int? Yil { get; set; }

    public int? Ay { get; set; }

    public int? Isyeriid { get; set; }

    public int? Stid { get; set; }

    public int? Cariid { get; set; }

    public int? Sevkid { get; set; }

    public decimal? Nettutar { get; set; }

    public string? Bgcolor { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
