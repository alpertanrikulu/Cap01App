using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Tahsilatturleri
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public string? Tur { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
