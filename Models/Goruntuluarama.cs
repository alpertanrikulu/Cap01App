using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Goruntuluarama
{
    public int Id { get; set; }

    public int? Arayanid { get; set; }

    public int? Arananid { get; set; }

    public string? Odano { get; set; }

    public DateTime? Bastarih { get; set; }

    public DateTime? Bittarih { get; set; }

    public bool? Devam { get; set; }

    public bool? Bildirildi { get; set; }
}
