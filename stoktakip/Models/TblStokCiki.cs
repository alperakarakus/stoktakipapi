using System;
using System.Collections.Generic;

namespace stoktakip.Models;

public partial class TblStokCiki
{
    public int Islemid { get; set; }

    public double Adet { get; set; }

    public double BirimFiyat { get; set; }

    public DateTime Tarih { get; set; }
}
