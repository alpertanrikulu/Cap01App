using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Dovizler
{
    public int Id { get; set; }

    public int Distid { get; set; }

    public string? Doviz { get; set; }

    public string? Kod { get; set; }

    public short? Nr { get; set; }

    public double Kur1 { get; set; }

    public double Kur2 { get; set; }

    public double Kur3 { get; set; }

    public double Kur4 { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
