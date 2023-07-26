using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class ZiyaretPerforman
{
    public long Id { get; set; }

    public int Stid { get; set; }

    public string? Isyeri { get; set; }

    public string? StKodu { get; set; }

    public string? StAdi { get; set; }

    public DateTime? RaporTarihFiltresi { get; set; }

    public string? PlanlananZiyaretTarihi { get; set; }

    public string ZiyaretBaslangici { get; set; } = null!;

    public string ZiyaretBitisi { get; set; } = null!;

    public string ZiyaretSuresi { get; set; } = null!;

    public int Cariid { get; set; }

    public string? CariKodu { get; set; }

    public string? CariUnvani { get; set; }

    public string SevkAdresiKodu { get; set; } = null!;

    public string SevkAdresiUnvani { get; set; } = null!;

    public string RotaIciMi { get; set; } = null!;

    public string SiparisVarMi { get; set; } = null!;

    public string TahsilatVarMi { get; set; } = null!;

    public string YerindeMi { get; set; } = null!;

    public string HaritadaGoster { get; set; } = null!;

    public int Gunno { get; set; }
}
