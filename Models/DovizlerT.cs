using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class DovizlerT
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public string? Doviz { get; set; }

    public string? Kod { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
