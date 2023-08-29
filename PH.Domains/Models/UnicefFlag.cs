using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefFlag
{
    public int Sno { get; set; }

    public string GovernCode { get; set; } = null!;

    public string GovernNameEn { get; set; } = null!;

    public string GovernNameAr { get; set; } = null!;

    public string DistrictCode { get; set; } = null!;

    public string DistrictNameEn { get; set; } = null!;

    public string DistrictNameAr { get; set; } = null!;

    public string OzlaCode { get; set; } = null!;

    public string OzlaName { get; set; } = null!;

    public string VillageCode { get; set; } = null!;

    public string? VillageName { get; set; }

    public string? GovernCodeV { get; set; }

    public string? DistrictCodeV { get; set; }

    public string? OzlaCodeV { get; set; }

    public string? VillageCodeV { get; set; }
}
