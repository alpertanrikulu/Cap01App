using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Faturasatirlari
{
    public int Id { get; set; }

    public int Distid { get; set; }

    public int? Siparisid { get; set; }

    public int? Siparisref { get; set; }

    public string Siparisno { get; set; } = null!;

    public int? Faturaid { get; set; }

    public int Faturaturid { get; set; }

    public int? Cariid { get; set; }

    public int Sevkid { get; set; }

    public int? Irsaliyeref { get; set; }

    public int Ambarid { get; set; }

    public DateTime? Tarih { get; set; }

    public short? Yil { get; set; }

    public short? Ay { get; set; }

    public string? Irsaliyeno { get; set; }

    public string? Irsaliyebelgeno { get; set; }

    public int Satirref { get; set; }

    public short? Satirturu { get; set; }

    public int? Urunid { get; set; }

    public int? Urunref { get; set; }

    public double? Miktar { get; set; }

    public int? Birimid { get; set; }

    public double? Birimfiyat { get; set; }

    public double? Bruttutar { get; set; }

    public double? Indirim { get; set; }

    public double? Nettutar { get; set; }

    public double? Kdv { get; set; }

    public int Dovizid { get; set; }

    public double? Kur { get; set; }

    public string Satiraciklama { get; set; } = null!;

    public int? Kampanyadetayid { get; set; }

    public DateTime? Kayittarihi { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
