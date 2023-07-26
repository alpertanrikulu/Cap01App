using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Ziyaretler
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public int? Stid { get; set; }

    public int? Stref { get; set; }

    public int? Sevkref { get; set; }

    public DateTime? Bastarih { get; set; }

    public DateTime? Bittarih { get; set; }

    public bool? Yerindemi { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Sevklat { get; set; }

    public decimal? Sevklng { get; set; }

    public decimal? Baslat { get; set; }

    public decimal? Baslng { get; set; }

    public decimal? Bitlat { get; set; }

    public decimal? Bitlng { get; set; }

    public decimal? Siparistutari { get; set; }

    public decimal? Tahsilattutari { get; set; }

    public decimal? Iadetutari { get; set; }

    public DateTime? Songuncelleme { get; set; }

    public string? Uid { get; set; }

    public int? Cariid { get; set; }

    public bool? Devam { get; set; }

    public bool? Rotaici { get; set; }
}
