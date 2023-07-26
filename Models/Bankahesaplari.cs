using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Bankahesaplari
{
    public int Id { get; set; }

    public int Distid { get; set; }

    public string? Bankakodu { get; set; }

    public string? Bankaadi { get; set; }

    public int Bankaref { get; set; }

    public string? Bankahesapkodu { get; set; }

    public string? Bankahesapadi { get; set; }

    public int Bankahesapref { get; set; }

    public short? Bankahesapturnr { get; set; }

    public string Bakahesapturu { get; set; } = null!;

    public int Durum { get; set; }

    public string Muhasebekodu { get; set; } = null!;
}
