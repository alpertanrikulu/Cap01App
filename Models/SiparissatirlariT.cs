using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class SiparissatirlariT
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public int? Siparisid { get; set; }

    public int? Urunid { get; set; }

    public int? Faturaref { get; set; }

    public int? Irsaliyeref { get; set; }

    public int? Tip { get; set; }

    public string? Tipstr { get; set; }

    public int? Itemref { get; set; }

    public decimal? Miktar { get; set; }

    public int? Birimid { get; set; }

    public decimal? Sevkmiktar { get; set; }

    public bool? Durum { get; set; }

    public decimal? Kdv { get; set; }

    public int? Dovizid { get; set; }

    public decimal? Birimfiyat { get; set; }

    public decimal? Satirnettl { get; set; }

    public decimal? Satirkdvtl { get; set; }

    public decimal? Satirtoplamtl { get; set; }

    public string? Indirimorani { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? Iptaltarihi { get; set; }

    public bool? Iptaldurum { get; set; }

    public decimal? Iptalmiktar { get; set; }

    public bool? Aktarimdurum { get; set; }

    public DateTime? Songuncelleme { get; set; }

    public string? Sid { get; set; }

    public int? Kampanyadetayid { get; set; }

    public string? Kampanyaisim { get; set; }
}
