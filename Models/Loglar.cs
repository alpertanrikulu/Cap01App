using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Loglar
{
    public int Id { get; set; }

    public int? Kullaniciid { get; set; }

    public int? Distid { get; set; }

    public string? Aciklama { get; set; }

    public string? Ipadres { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
