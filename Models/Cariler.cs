using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Cariler
{
    public int Id { get; set; }

    public int Distid { get; set; }

    public int Cariref { get; set; }

    public string? Kodu { get; set; }

    public string? Unvani { get; set; }

    public string? Ozelalan1 { get; set; }

    public string? Ozelalan2 { get; set; }

    public string? Ozelalan3 { get; set; }

    public string? Ozelalan4 { get; set; }

    public string? Ozelalan5 { get; set; }

    public string? Kanal1 { get; set; }

    public string? Kanal2 { get; set; }

    public string? Kanal3 { get; set; }

    public string Kanal4 { get; set; } = null!;

    public string Kanal5 { get; set; } = null!;

    public string? Yetkikodu { get; set; }

    public string? Ticislgrb { get; set; }

    public bool? Durum { get; set; }

    public bool? Sipariseacik { get; set; }

    public string? Ulke { get; set; }

    public string? Sehir { get; set; }

    public string? Ilce { get; set; }

    public string? Adres { get; set; }

    public string? Tel { get; set; }

    public string? Faks { get; set; }

    public string? Ilgili { get; set; }

    public string? Eposta { get; set; }

    public string? Gsm { get; set; }

    public string? Ilgili2 { get; set; }

    public string? Eposta2 { get; set; }

    public string? Gsm2 { get; set; }

    public string? Vno { get; set; }

    public string? Vdairesi { get; set; }

    public int Opref { get; set; }

    public string Opkodu { get; set; } = null!;

    public string Opaciklama { get; set; } = null!;

    public string Muhkodu { get; set; } = null!;

    public bool? Efatura { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public int Sevkadresref { get; set; }

    public string Bolge { get; set; } = null!;

    public string Indirimkod { get; set; } = null!;

    public string Grupkodu { get; set; } = null!;

    public string Kampanyakod { get; set; } = null!;

    public decimal? Guncelrisk { get; set; }

    public decimal? Risklimiti { get; set; }

    public double Bakiye { get; set; }

    public bool? Aktarim { get; set; }

    public bool? Onay { get; set; }

    public DateTime Songuncelleme { get; set; }
}
