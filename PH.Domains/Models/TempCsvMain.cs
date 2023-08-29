using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class TempCsvMain
{
    public string? Uniquecode { get; set; }

    public string? Olduniquecode { get; set; }

    public string? Membercode { get; set; }

    public string? Primarybeneficiarynames { get; set; }

    public string? Primarybeneficiaryfamilyname { get; set; }

    public string? Gender { get; set; }

    public string? Governoratewherehelives { get; set; }

    public string? Districtwherehelives { get; set; }

    public string? Ozlawherehelives { get; set; }

    public string? Villagewherehelives { get; set; }

    public string? Amounttobepaid { get; set; }

    public string? Flagnopayment { get; set; }

    public string? Flagoutreach { get; set; }

    public string? Cmcode { get; set; }
}
