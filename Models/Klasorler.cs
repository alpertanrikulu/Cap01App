using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Klasorler
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public int? Isyeriid { get; set; }

    public string? Isim { get; set; }

    public string? Klasorisim { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
