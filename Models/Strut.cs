using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Strut
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public int? Sevkid { get; set; }

    public int? Stid { get; set; }

    public int? Cariid { get; set; }

    public DateTime? Kayittarihi { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
