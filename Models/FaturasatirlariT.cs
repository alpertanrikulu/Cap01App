using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class FaturasatirlariT
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public int? Siparisid { get; set; }

    public int? Siparisref { get; set; }

    public string? Siparisno { get; set; }

    public int? Faturaid { get; set; }

    public int? Faturaturid { get; set; }

    public int? Irsaliyeref { get; set; }

    public int? Ambarid { get; set; }

    public DateTime? Tarih { get; set; }

    public int? Yil { get; set; }

    public int? Ay { get; set; }

    public string? Irsaliyeno { get; set; }

    public string? Irsaliyebelgeno { get; set; }

    public int? Satirref { get; set; }

    public byte? Satirturu { get; set; }

    public int? Urunid { get; set; }

    public int? Urunref { get; set; }

    public decimal? Miktar { get; set; }

    public int? Birimid { get; set; }

    public decimal? Birimfiyat { get; set; }

    public int? Dovizid { get; set; }

    public decimal? Bruttutar { get; set; }

    public decimal? Indirim { get; set; }

    public decimal? Nettutar { get; set; }

    public decimal? Kdvtutari { get; set; }

    public decimal? Kdvorani { get; set; }

    public decimal? Kdv { get; set; }

    public decimal? Kur { get; set; }

    public int? Kampanyadetayid { get; set; }

    public DateTime? Kayittarihi { get; set; }

    public string? Uid { get; set; }

    public decimal? Indirimorani { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
