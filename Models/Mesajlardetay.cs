using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Mesajlardetay
{
    public int Id { get; set; }

    public int? Ozelid { get; set; }

    public int? Stid { get; set; }

    public bool? Okundu { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
