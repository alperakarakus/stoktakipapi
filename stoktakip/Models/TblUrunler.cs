using System;
using System.Collections.Generic;

namespace stoktakip.Models;

public partial class TblUrunler
{
    public int Urunid { get; set; }

    public string UrunAd { get; set; } = null!;

    public int UrunKod { get; set; }

    public string? Aciklama { get; set; }

    public int MinStok { get; set; }

    public int MaxStok { get; set; }
}
