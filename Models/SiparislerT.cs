using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class SiparislerT
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public int? Isyeriid { get; set; }

    public int? Cariid { get; set; }

    public int? Sevkid { get; set; }

    public int? Stid { get; set; }

    public int? Kullaniciid { get; set; }

    public int? Erpid { get; set; }

    public decimal? Nettl { get; set; }

    public decimal? Kdvtl { get; set; }

    public decimal? Toplamtl { get; set; }

    public int? Onaydurum { get; set; }

    public int? Aktarimdurum { get; set; }

    public DateTime? Termintarihi { get; set; }

    public DateTime? Kayittarihi { get; set; }

    public string? Aciklama { get; set; }

    public string? Kargodurum { get; set; }

    public string? Takipurl { get; set; }

    public byte? Iadesebepid { get; set; }

    public int? Siparisturu { get; set; }

    public decimal? Bruttl { get; set; }

    public decimal? Toplamindirim { get; set; }

    public string? Uid { get; set; }

    public string? Sid { get; set; }

    public bool? Tamamla { get; set; }

    public string? Odemeplani { get; set; }

    public int? Odemeplaniid { get; set; }

    public string? Ilgili { get; set; }

    public int? Ambarid { get; set; }

    public string? Ambar { get; set; }

    public string? Aktarimmesaji { get; set; }

    public bool? Iptal { get; set; }

    public string? Fatura { get; set; }

    public int? Faturaid { get; set; }

    public string? Faturauid { get; set; }

    public DateTime? Songuncelleme { get; set; }

    public int? Sipariskanal { get; set; }

    public string? Tabid { get; set; }
}
