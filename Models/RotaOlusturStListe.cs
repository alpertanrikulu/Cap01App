using System;
using System.Collections.Generic;

namespace Cap01App.Models;

public partial class RotaOlusturStListe
{
    public int? Id { get; set; }

    public int? Stid { get; set; }

    public int Periyodgun { get; set; }

    public DateTime Periyodbaslangic { get; set; }

    public DateTime? Guncellemebaslangic { get; set; }
}
