using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Borcyaslandirmaraporu
{
    public int Id { get; set; }

    public int? Yil { get; set; }

    public int? Ay { get; set; }

    public int? Cariid { get; set; }

    public int? Isyeriid { get; set; }

    public int? Stid { get; set; }

    public decimal? Borc { get; set; }

    public decimal? Alacak { get; set; }

    public decimal? Bakiye { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
