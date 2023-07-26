using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Mesajlar
{
    public int Id { get; set; }

    public int? Gonderenid { get; set; }

    public int? Gonderilenid { get; set; }

    public string? Mesaj { get; set; }

    public DateTime? Tarih { get; set; }

    public int? Ozelid { get; set; }

    public string? Tarihstr { get; set; }

    public string? Isimsoyisim { get; set; }
}
