using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Urunler
{
    public int Id { get; set; }

    public byte? Distid { get; set; }

    public int Urunref { get; set; }

    public short? Birimsetid { get; set; }

    public short? Isyeriid { get; set; }

    public string? Kodu { get; set; }

    public string? Adi { get; set; }

    public string? Kisaadi { get; set; }

    public string? Tur { get; set; }

    public string Barkod { get; set; } = null!;

    public string? Uretici { get; set; }

    public string Muadil { get; set; } = null!;

    public short? Kategoriid { get; set; }

    public string Imgurl1 { get; set; } = null!;

    public string Imgurl2 { get; set; } = null!;

    public string Imgurl3 { get; set; } = null!;

    public string Imgurl4 { get; set; } = null!;

    public string Imgurl5 { get; set; } = null!;

    public string? Ozelalan1 { get; set; }

    public string? Ozelalan2 { get; set; }

    public string? Ozelalan3 { get; set; }

    public string? Ozelalan4 { get; set; }

    public string? Ozelalan5 { get; set; }

    public string? Aciklama { get; set; }

    public bool? Durum { get; set; }

    public DateTime? Kayittarihi { get; set; }

    public decimal? Kdvalis { get; set; }

    public decimal? Kdvsatis { get; set; }

    public bool? Psku { get; set; }

    public bool? Yenimi { get; set; }

    public string? Yetkikodu { get; set; }

    public string? Grupkodu { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
