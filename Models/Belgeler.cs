using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Belgeler
{
    public int Id { get; set; }

    public int? Klasorid { get; set; }

    public int? Distid { get; set; }

    public string? Baslik { get; set; }

    public string? Isim { get; set; }

    public string? Link { get; set; }

    public DateTime? Songuncelleme { get; set; }

    public string? Kullaniciid { get; set; }

    public int? Isyeriid { get; set; }
}
