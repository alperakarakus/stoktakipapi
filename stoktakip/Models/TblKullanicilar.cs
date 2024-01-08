using System;
using System.Collections.Generic;

namespace stoktakip.Models;

public partial class TblKullanicilar
{
    public int KullaniciId { get; set; }

    public string KullaniciAd { get; set; } = null!;

    public string Parola { get; set; } = null!;

    public int? Yetki { get; set; }
}
