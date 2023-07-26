using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Birimler
{
    public int Id { get; set; }

    public int Distid { get; set; }

    public int Birimref { get; set; }

    public int Birimsetid { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public bool? Anabirim { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
