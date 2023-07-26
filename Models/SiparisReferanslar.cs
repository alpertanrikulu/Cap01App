using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class SiparisReferanslar
{
    public int Sipref { get; set; }

    public string? Sipno { get; set; }

    public int? Siparisid { get; set; }

    public string Faturano { get; set; } = null!;

    public DateTime Faturatarihi { get; set; }

    public string Irsaliyeno { get; set; } = null!;

    public DateTime Irsaliyetarihi { get; set; }

    public DateTime Basimtarihi { get; set; }

    public DateTime Yuklemetarihi { get; set; }

    public DateTime Teslimtarihi { get; set; }

    public string Durum { get; set; } = null!;

    public DateTime? Songuncelleme { get; set; }
}
