using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Odemeplanlari
{
    public int Id { get; set; }

    public int Distid { get; set; }

    public int Odemeref { get; set; }

    public int No { get; set; }

    public string? Kodu { get; set; }

    public string? Aciklama { get; set; }

    public bool? Durum { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
