using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class BorctakipT
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public int? Yil { get; set; }

    public int? Ay { get; set; }

    public int? Cariid { get; set; }

    public int? Cariref { get; set; }

    public int? Stref { get; set; }

    public int? Stid { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Vadetarihi { get; set; }

    public short? Isyeri { get; set; }

    public int? Isyeriid { get; set; }

    public string? Fisno { get; set; }

    public int? Fisturuid { get; set; }

    public string? Fisturudetay { get; set; }

    public string? Doviz { get; set; }

    public bool? Kapali { get; set; }

    public decimal? Borc { get; set; }

    public decimal? Alacak { get; set; }

    public decimal? Kapanan { get; set; }

    public decimal? Kalan { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
