using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Talepler
{
    public int Id { get; set; }

    public int? Isyeriid { get; set; }

    public int? Ambarid { get; set; }

    public int? Stid { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Termintarihi { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
