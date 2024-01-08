using System;
using System.Collections.Generic;

namespace stoktakip.Models;

public partial class TblMusteriler
{
    public int Musteriid { get; set; }

    public string FirmaAdi { get; set; } = null!;

    public string YetkiliAdSoyad { get; set; } = null!;

    public string? Adres { get; set; }

    public string? Mail { get; set; }

    public string Telefon { get; set; } = null!;
}
