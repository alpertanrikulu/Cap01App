using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Iadesebepleri
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public string? Iadesebepref { get; set; }

    public string? Aciklama { get; set; }

    public int? Siralama { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
