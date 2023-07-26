using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class BirimsetlerT
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
