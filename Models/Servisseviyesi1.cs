using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Servisseviyesi1
{
    public int Id { get; set; }

    public int? Yil { get; set; }

    public int? Ay { get; set; }

    public int Siparisid { get; set; }

    public string? SiparisNo { get; set; }

    public DateTime? SlTarih { get; set; }

    public DateTime? LogoTarih { get; set; }

    public int? Cariid { get; set; }

    public int? Stid { get; set; }

    public string? CariKodu { get; set; }

    public string? CariUnvani { get; set; }

    public string? SatirTuru { get; set; }

    public string? UrunKodu { get; set; }

    public string? UrunAdi { get; set; }

    public string? UrunYetkikodu { get; set; }

    public string? UrunGrupkodu { get; set; }

    public string? UrunOzelkod1 { get; set; }

    public string? UrunOzelkod2 { get; set; }

    public string? UrunOzelkod3 { get; set; }

    public string? UrunOzelkod4 { get; set; }

    public string? UrunOzelkod5 { get; set; }

    public decimal? SlMiktar { get; set; }

    public string? SlBirim { get; set; }

    public decimal? LogoMiktar { get; set; }

    public decimal? LogoSevkedilenMiktar { get; set; }

    public decimal? KalanMiktar { get; set; }

    public string? LogoBirim { get; set; }

    public decimal? FaturaMiktar { get; set; }

    public string? FaturaBirim { get; set; }

    public decimal? FaturaTutar { get; set; }

    public DateTime? Songuncelleme { get; set; }

    public int? Isyeriid { get; set; }
}
