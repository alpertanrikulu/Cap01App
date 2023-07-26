using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Kampanyadetaylari
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public int? Kampanyaid { get; set; }

    public DateTime? Bastarih { get; set; }

    public DateTime? Bittarih { get; set; }

    public string? Stid { get; set; }

    public string? Urunid { get; set; }

    public string? Urunkategoriid { get; set; }

    public string? Hedefurunid { get; set; }

    public decimal? Miktar { get; set; }

    public int? Birimid { get; set; }

    public decimal? Tutar { get; set; }

    public int? Dovizid { get; set; }

    public int? Mf { get; set; }

    public int? Mfbirimid { get; set; }

    public decimal? Miktarlimit { get; set; }

    public int? Limitbirimid { get; set; }

    public decimal? Tutarlimit { get; set; }

    public int? Limitdovizid { get; set; }

    public bool? Katli { get; set; }

    public decimal? Ozelfiyat { get; set; }

    public decimal? Isk1 { get; set; }

    public decimal? Isk2 { get; set; }

    public decimal? Isk3 { get; set; }

    public decimal? Isk4 { get; set; }

    public int? Oncelik { get; set; }

    public int? Kampanyatipid { get; set; }

    public string? Stidnot { get; set; }

    public string? Urunidnot { get; set; }

    public string? Urunkategorinot { get; set; }

    public string? Ad { get; set; }

    public string? Aciklama { get; set; }

    public string? Kisaad { get; set; }

    public int? Turid { get; set; }

    public decimal? Kullanilanmiktarlimit { get; set; }

    public decimal? Kullanilantutarlimit { get; set; }

    public bool? Zorunlu { get; set; }

    public string? Cariid { get; set; }

    public string? Cariidnot { get; set; }

    public string? Ozelalan1 { get; set; }

    public string? Ozelalan2 { get; set; }

    public string? Ozelalan3 { get; set; }

    public string? Ozelalan4 { get; set; }

    public string? Ozelalan5 { get; set; }

    public string? Kanal1 { get; set; }

    public string? Kanal2 { get; set; }

    public string? Kanal3 { get; set; }

    public string? Kanal4 { get; set; }

    public string? Kanal5 { get; set; }

    public string? Ozelalan1not { get; set; }

    public string? Ozelalan2not { get; set; }

    public string? Ozelalan3not { get; set; }

    public string? Ozelalan4not { get; set; }

    public string? Ozelalan5not { get; set; }

    public string? Kanal1not { get; set; }

    public string? Kanal2not { get; set; }

    public string? Kanal3not { get; set; }

    public string? Kanal4not { get; set; }

    public string? Kanal5not { get; set; }

    public string? Grupkodu { get; set; }

    public string? Grupkodunot { get; set; }

    public string? Odemeplanid { get; set; }

    public string? Odemeplanidnot { get; set; }

    public DateTime? Songuncelleme { get; set; }

    public string? Urunozelkod1 { get; set; }

    public string? Urunozelkod2 { get; set; }

    public string? Urunozelkod3 { get; set; }

    public string? Urunozelkod4 { get; set; }

    public string? Urunozelkod5 { get; set; }

    public string? Urunozelkod1not { get; set; }

    public string? Urunozelkod2not { get; set; }

    public string? Urunozelkod3not { get; set; }

    public string? Urunozelkod4not { get; set; }

    public string? Urunozelkod5not { get; set; }

    public bool? Durum { get; set; }

    public string? Urunyetkikodu { get; set; }

    public string? Urunyetkikodunot { get; set; }

    public string? Odemeplanlari { get; set; }

    public string? Odemeplanlarinot { get; set; }

    public bool? Silindi { get; set; }

    public string? Guncelleyenkullanici { get; set; }
}
