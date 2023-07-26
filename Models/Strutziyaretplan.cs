using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Strutziyaretplan
{
    public int Id { get; set; }

    public byte? Distid { get; set; }

    public short? Stid { get; set; }

    public int? Cariid { get; set; }

    public int? Sevkid { get; set; }

    public short? Kayitid { get; set; }

    public DateTime? Ziyarettarihi { get; set; }

    public DateTime? Kayittarihi { get; set; }

    public DateTime? Songuncelleme { get; set; }

    public string? Hesaplananhafta { get; set; }

    public string? Ziyarettarihistr { get; set; }

    public DateTime? Hesaplananhaftatarih { get; set; }
}
