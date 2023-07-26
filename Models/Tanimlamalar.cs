using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Tanimlamalar
{
    public int Id { get; set; }

    public int? Tip { get; set; }

    public int? Distid { get; set; }

    public int? Isyeriid { get; set; }

    public string? Kod { get; set; }

    public string? Tanim { get; set; }

    public bool? Durum { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
