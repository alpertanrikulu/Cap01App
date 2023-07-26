using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class RutGunMevcut
{
    public long Id { get; set; }

    public string? Stkodu { get; set; }

    public string? Stadi { get; set; }

    public string Gundurum { get; set; } = null!;

    public string? Carikodu { get; set; }

    public string? Cariunvani { get; set; }

    public string? Kanal1 { get; set; }

    public string? Kanal2 { get; set; }

    public string? Kanal3 { get; set; }

    public string Kanal1isim { get; set; } = null!;

    public string Kanal2isim { get; set; } = null!;

    public string Kanal3isim { get; set; } = null!;

    public string Sevkkodu { get; set; } = null!;

    public string Sevkadresi { get; set; } = null!;

    public byte Gun { get; set; }

    public string Gunadi { get; set; } = null!;
}
