using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class StistatistikEski
{
    public int Id { get; set; }

    public int? Stid { get; set; }

    public int? Yil { get; set; }

    public short? Ay { get; set; }

    public int? Isyeriid { get; set; }

    public int? Dovizid { get; set; }

    public decimal? Cirohedef { get; set; }

    public decimal? Cirogercek { get; set; }

    public int? Kapsamhedef { get; set; }

    public int? Kapsamgercek { get; set; }

    public int? Pskuhedef { get; set; }

    public int? Pskugercek { get; set; }

    public int? Markahedef { get; set; }

    public int? Markagercek { get; set; }

    public int Pmarkahedef { get; set; }

    public int Pmarkagercek { get; set; }

    public decimal? Tahsilathedef { get; set; }

    public decimal? Tahsilatgercek { get; set; }

    public int? Adethedef { get; set; }

    public int? Adetgercek { get; set; }

    public decimal? Cirohakedis { get; set; }

    public decimal? Kapsamhakedis { get; set; }

    public decimal? Markahakedis { get; set; }

    public decimal? Pwmhakedis { get; set; }

    public decimal? Pskuhakedis { get; set; }

    public decimal? Tahsilat { get; set; }

    public decimal? Hakedis { get; set; }

    public int? Rozet { get; set; }

    public int? Stsiralama { get; set; }

    public decimal? Tahsilathakedis { get; set; }

    public decimal? Toplamhakedis { get; set; }

    public DateTime? Songuncelleme { get; set; }
}
