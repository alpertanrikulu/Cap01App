using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Hatirlaticilar
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public int? Cariid { get; set; }

    public int? Kullaniciid { get; set; }

    public string? Baslik { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? Bastarih { get; set; }

    public DateTime? Bittarih { get; set; }

    public int? Tur { get; set; }

    public bool? Durum { get; set; }

    public string? Saat { get; set; }

    public decimal? Lat { get; set; }

    public decimal? Lng { get; set; }

    public int? Mesafe { get; set; }

    public DateTime? Songuncelleme { get; set; }

    public string? Hid { get; set; }

    public bool? Silinecek { get; set; }

    public bool? Gonderildi { get; set; }

    public int? Sevkid { get; set; }

    public DateTime? Songosterim { get; set; }
}
