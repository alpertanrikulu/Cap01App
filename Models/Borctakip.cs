using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Borctakip
{
    public int Id { get; set; }

    public int Distid { get; set; }

    public int? Cariid { get; set; }

    public int? Cariref { get; set; }

    public int Stref { get; set; }

    public int Stid { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Vadetarihi { get; set; }

    public int Isyeri { get; set; }

    public string? Fisno { get; set; }

    public int? Fisturuid { get; set; }

    public string Fisturudetay { get; set; } = null!;

    public string? Doviz { get; set; }

    public int Kapali { get; set; }

    public double? Borc { get; set; }

    public double? Alacak { get; set; }

    public int Kapanan { get; set; }

    public double? Kalan { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
