using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class TempRegion
{
    public string? Name { get; set; }

    public string? LocalName { get; set; }

    public string? Liquidity { get; set; }

    public string? Country { get; set; }

    public string? CityEng { get; set; }

    public string? CityArb { get; set; }

    public string? Descr { get; set; }
}
