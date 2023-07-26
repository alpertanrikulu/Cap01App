using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Isyerleri
{
    public int Id { get; set; }

    public short? Distid { get; set; }

    public short? Isyerinr { get; set; }

    public string? Isyeri { get; set; }

    public short? Kanal { get; set; }

    public DateTime Songuncelleme { get; set; }

    public int? Pskukanal { get; set; }
}
