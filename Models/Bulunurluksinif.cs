using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Bulunurluksinif
{
    public int Id { get; set; }

    public DateTime? Bastar { get; set; }

    public DateTime? Bittar { get; set; }

    public int? Isyeriid { get; set; }

    public string? Aciklama { get; set; }

    public int? Periyot { get; set; }

    public int? Kullaniciid { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
