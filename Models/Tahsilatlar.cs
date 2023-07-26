using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Tahsilatlar
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public int? Stid { get; set; }

    public int? Sevkid { get; set; }

    public int? Cariid { get; set; }

    public int? Tahsilatturid { get; set; }

    public DateTime? Vadetarih { get; set; }

    public DateTime? Islemtarih { get; set; }

    public int? Dovizid { get; set; }

    public decimal? Tutar { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? Kayittarihi { get; set; }

    public int? Kayitid { get; set; }

    public DateTime? Songuncelleme { get; set; }

    public string? Tid { get; set; }

    public bool? Tamamla { get; set; }

    public bool? Gonderildi { get; set; }

    public bool? Kaydet { get; set; }

    public string? Gid { get; set; }

    public string? Yontem { get; set; }

    public string? Bankaadi { get; set; }

    public string? Makbuznumarasi { get; set; }

    public string? Yetkili { get; set; }

    public string? Bankahesabi { get; set; }

    public string? Serino { get; set; }

    public string? Borclu { get; set; }

    public string? Vkn { get; set; }

    public string? Subeadi { get; set; }

    public string? Hesapno { get; set; }

    public string? Resim { get; set; }

    public string? Uid { get; set; }

    public DateTime? Tanzimtarihi { get; set; }

    public bool? Onay { get; set; }

    public bool Aktarim { get; set; }

    public int? Kasaid { get; set; }
}
