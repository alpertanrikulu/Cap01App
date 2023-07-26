using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Parametreler
{
    public int Id { get; set; }

    public int? Distid { get; set; }

    public int? Isyeriid { get; set; }

    public bool? Siparisonay { get; set; }

    public int? Siparissatir { get; set; }

    public decimal? Siparistutar { get; set; }

    public byte? Alokasyon { get; set; }

    public DateTime? Songuncelleme { get; set; }

    public bool? Kdvdegissin { get; set; }

    public bool? Odemeplanidegistirilsin { get; set; }

    public bool? Birimfiyatsecsin { get; set; }

    public short Senkronizasyon { get; set; }

    public short? Lokasyonguncelleme { get; set; }

    public short? Parabirimiid { get; set; }

    public bool? Kampanyaolmayanstok { get; set; }

    public int? Onaydurumu { get; set; }

    public bool? Sicaksatis { get; set; }

    public bool? Faturazorunlukayit { get; set; }

    public bool? Gunbasiirsaliyezorunlu { get; set; }

    public int Liderpanosusayisi { get; set; }

    public byte? Sepetiadehesabi { get; set; }

    public byte? Iadestbilgisi { get; set; }

    public string? Photo1 { get; set; }

    public string? Photo2 { get; set; }

    public string? Photo3 { get; set; }

    public string? Photo4 { get; set; }

    public string? Photo5 { get; set; }

    public bool? Photo1aktiflik { get; set; }

    public bool? Photo2aktiflik { get; set; }

    public bool? Photo3aktiflik { get; set; }

    public bool? Photo4aktiflik { get; set; }

    public bool? Photo5aktiflik { get; set; }

    public int? Dovizkuru { get; set; }

    public bool? Borctakipturu { get; set; }

    public bool? Siparispaylas { get; set; }

    public int? Konumtoleransi { get; set; }

    public bool? Sureklikonumalma { get; set; }

    public bool? Stsecim { get; set; }

    public bool? Ambarsecim { get; set; }

    public bool? Iadesebepsecim { get; set; }

    public int? Stidvarsayilan { get; set; }

    public int? Ambaridvarsayilan { get; set; }

    public int? Iadesebepidvarsayilan { get; set; }

    public bool? Ziyarettekonumuyarisi { get; set; }

    public bool? Stokondaliklisayilar { get; set; }

    public bool? Caritahsilatbilgisi { get; set; }

    public bool? Cirogozuksun { get; set; }

    public bool? Kapsamgozuksun { get; set; }

    public bool? Pskumslgozuksun { get; set; }

    public bool? Pmarkagozuksun { get; set; }

    public bool? Adetgozuksun { get; set; }

    public bool? Strutgozuksun { get; set; }

    public string? Openweatherapi { get; set; }

    public int? Randomcount { get; set; }

    public int? Alokasyonuyariyuzde { get; set; }

    public string Dovizid { get; set; } = null!;

    public int? Varsayilandovizidbo { get; set; }

    public int? Varsayilandovizidmo { get; set; }

    public string? VidyoIoAppid { get; set; }

    public string? VidyoIoKey { get; set; }

    public bool? Ziyaretsizsiparis { get; set; }

    public bool? Risklimitiuyarisi { get; set; }

    public byte? Ziyarettekonumuyarisi2 { get; set; }

    public bool? Fiyatdurum { get; set; }

    public string? Mailisim { get; set; }

    public string? Mailsmtp { get; set; }

    public string? Mailport { get; set; }

    public string? Maileposta { get; set; }

    public string? Mailsifre { get; set; }

    public string? Ambarminimumsiparistutar { get; set; }

    public bool? Ambarminimumtutaretkin { get; set; }

    public int? Pskukanal { get; set; }

    public string? Ambarfiyatgosterimi { get; set; }
}
