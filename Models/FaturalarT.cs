using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class FaturalarT
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public int? Cariid { get; set; }

    public int? Faturaref { get; set; }

    public int? Isyeriid { get; set; }

    public int? Musteriid { get; set; }

    public string? Odemeplani { get; set; }

    public int? Sevkid { get; set; }

    public int? Stid { get; set; }

    public string? Ambar { get; set; }

    public int? Ambarid { get; set; }

    public int? Faturaturid { get; set; }

    public string? Faturano { get; set; }

    public string? Belgeno { get; set; }

    public DateTime? Tarih { get; set; }

    public int Ay { get; set; }

    public int? Yil { get; set; }

    public string? Tur { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? Bruttutar { get; set; }

    public decimal? Indirim { get; set; }

    public decimal? Nettutar { get; set; }

    public decimal? Kdv { get; set; }

    public int? Dovizid { get; set; }

    public decimal? Kur { get; set; }

    public DateTime? Kayittarihi { get; set; }

    public string? Uid { get; set; }

    public byte? Onaydurum { get; set; }

    public bool? Aktarimdurum { get; set; }

    public bool? Iptal { get; set; }

    public int? Sayfasayisi { get; set; }

    public DateTime? Songuncelleme { get; set; }

    public decimal? Kdvtutari { get; set; }

    public bool? Tamamla { get; set; }

    public bool? Onay1 { get; set; }

    public string? Aciklama { get; set; }

    public string? Iadesebebi { get; set; }

    public int? Iadeyialan { get; set; }
}
