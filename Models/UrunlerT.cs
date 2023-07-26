using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class UrunlerT
{
    public int Id { get; set; }

    public int Distid { get; set; }

    public int? Urunref { get; set; }

    public int? Birimsetid { get; set; }

    public int? Dovizid { get; set; }

    public int? Isyeriid { get; set; }

    public string? Kodu { get; set; }

    public string? Adi { get; set; }

    public string? Kisaadi { get; set; }

    public string? Tur { get; set; }

    public string? Barkod { get; set; }

    public string? Uretici { get; set; }

    public string? Muadil { get; set; }

    public int? Kategoriid { get; set; }

    public string? Raf { get; set; }

    public string? Kasa { get; set; }

    public string? Marka { get; set; }

    public string? Model { get; set; }

    public string? Sezon { get; set; }

    public string? Imgurl1 { get; set; }

    public string? Imgurl2 { get; set; }

    public string? Imgurl3 { get; set; }

    public string? Imgurl4 { get; set; }

    public string? Imgurl5 { get; set; }

    public string? Ozelalan1 { get; set; }

    public string? Ozelalan2 { get; set; }

    public string? Ozelalan3 { get; set; }

    public string? Ozelalan4 { get; set; }

    public string? Ozelalan5 { get; set; }

    public string? Aciklama { get; set; }

    public bool? Durum { get; set; }

    public DateTime? Kayittarihi { get; set; }

    public decimal? Stok { get; set; }

    public decimal? Kdvalis { get; set; }

    public decimal? Kdvsatis { get; set; }

    public decimal? Fiyat { get; set; }

    public bool? Psku { get; set; }

    public bool? Yenimi { get; set; }

    public string? Grupkodu { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
