using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Hedeftipleri
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public string? Adi { get; set; }

    public int? Periyodid { get; set; }

    public int? Baslangicayi { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
