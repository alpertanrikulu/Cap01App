using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class Event
{
    public int EventId { get; set; }

    public int? Isyeriid { get; set; }

    public string? Title { get; set; }

    public DateTime? EventStart { get; set; }

    public DateTime? EventEnd { get; set; }

    public string? Renk { get; set; }

    public bool? AllDay { get; set; }

    public string? Description { get; set; }
}
