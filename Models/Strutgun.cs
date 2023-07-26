using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Strutgun
{
    public int Id { get; set; }

    public byte? Distid { get; set; }

    public int? Sevkid { get; set; }

    public int? Cariid { get; set; }

    public short? Stid { get; set; }

    public byte? Gun { get; set; }

    public short? Kayitid { get; set; }

    public DateTime? Kayittarihi { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
