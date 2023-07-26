using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Sevkadresleri
{
    public int Id { get; set; }

    public int Distid { get; set; }

    public int Sevkref { get; set; }

    public int? Cariref { get; set; }

    public string? Kodu { get; set; }

    public string? Unvani { get; set; }

    public string? Ozelalan1 { get; set; }

    public string? Kanal1 { get; set; }

    public bool? Durum { get; set; }

    public string? Ulke { get; set; }

    public string? Sehir { get; set; }

    public string? Ilce { get; set; }

    public string? Adres { get; set; }

    public string? Tel1 { get; set; }

    public string? Tel2 { get; set; }

    public string? Faks { get; set; }

    public string? Ilgili { get; set; }

    public string? Eposta { get; set; }

    public string? Vno { get; set; }

    public string? Vdairesi { get; set; }

    public string Opkodu { get; set; } = null!;

    public string Opaciklama { get; set; } = null!;

    public string Muhkodu { get; set; } = null!;

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public string Bolge { get; set; } = null!;

    public string Indirimkod { get; set; } = null!;

    public string? Grupkodu { get; set; }

    public string Kampanyakod { get; set; } = null!;

    public DateTime? Songuncelleme { get; set; }
}
