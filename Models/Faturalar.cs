using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Faturalar
{
    public int Id { get; set; }

    public int Distid { get; set; }

    public int Cariid { get; set; }

    public int Faturaref { get; set; }

    public int Isyeriid { get; set; }

    public int Musteriid { get; set; }

    public int Sevkref { get; set; }

    public int Stid { get; set; }

    public int Ambarid { get; set; }

    public int? Odemeplanid { get; set; }

    public int Faturaturid { get; set; }

    public string? Faturano { get; set; }

    public string? Belgeno { get; set; }

    public DateTime? Tarih { get; set; }

    public int? Ay { get; set; }

    public int? Yil { get; set; }

    public string? Tur { get; set; }

    public double? Miktar { get; set; }

    public double? Bruttutar { get; set; }

    public double? Indirim { get; set; }

    public double? Nettutar { get; set; }

    public double? Kdv { get; set; }

    public int Dovizid { get; set; }

    public double? Kur { get; set; }

    public DateTime? Kayittarihi { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
