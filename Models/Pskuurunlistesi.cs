using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Pskuurunlistesi
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public int? Isyeriid { get; set; }

    public int? Urunref { get; set; }

    public string? Kanal { get; set; }

    public DateTime? Tarih { get; set; }

    public int? Kullaniciid { get; set; }

    public int? Periyodid { get; set; }

    public int? Yil { get; set; }

    public int? Ay { get; set; }

    public int? Ceyrek { get; set; }

    public int? Yarim { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
