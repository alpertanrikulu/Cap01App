using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Log
{
    public int Id { get; set; }

    public int? Kullaniciid { get; set; }

    public string? Tablo { get; set; }

    public string? Islem { get; set; }

    public string? Oncekideger { get; set; }

    public string? Sonrakideger { get; set; }

    public DateTime? Tarih { get; set; }
}
