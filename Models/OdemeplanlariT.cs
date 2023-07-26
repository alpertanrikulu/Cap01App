using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class OdemeplanlariT
{
    public int Id { get; set; }

    public int Distid { get; set; }

    public string? Odemeref { get; set; }

    public int No { get; set; }

    public string Kod { get; set; } = null!;

    public string Aciklama { get; set; } = null!;

    public DateTime? Songuncelleme { get; set; }
}
