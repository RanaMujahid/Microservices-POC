using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefRemtAmnt
{
    public long UnicefRemtAmntId { get; set; }

    public long RemtId { get; set; }

    public decimal MainAmnt { get; set; }

    public decimal ExtraAmnt { get; set; }

    public decimal? MainAmntSouth { get; set; }

    public decimal? ExtraAmntSouth { get; set; }

    public decimal? TotalAmntUsdNorth { get; set; }

    public decimal? TotalAmntUsdSouth { get; set; }
}
