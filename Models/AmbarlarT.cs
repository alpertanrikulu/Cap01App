using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class AmbarlarT
{
    public int Id { get; set; }

    public int Distid { get; set; }

    public int Ambarnr { get; set; }

    public string Isim { get; set; } = null!;

    public int? Isyeriid { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
