using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Bolumler
{
    public int Id { get; set; }

    public int Distid { get; set; }

    public short? Bolumnr { get; set; }

    public string? Bolum { get; set; }

    public int Kanal { get; set; }

    public DateTime Songuncelleme { get; set; }
}
