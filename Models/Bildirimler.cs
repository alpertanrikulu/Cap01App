using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Bildirimler
{
    public int Id { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Kullaniciid { get; set; }

    public string? Mesaj { get; set; }

    public int? Distid { get; set; }
}
