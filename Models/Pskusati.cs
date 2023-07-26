using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Pskusati
{
    public int Id { get; set; }

    public int? Cariid { get; set; }

    public int? Stid { get; set; }

    public int? Isyeriid { get; set; }

    public int? Yil { get; set; }

    public int? Ay { get; set; }

    public int? Pskulistid { get; set; }

    public int? Urunid { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
