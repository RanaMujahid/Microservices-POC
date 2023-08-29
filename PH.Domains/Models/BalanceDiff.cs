using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class BalanceDiff
{
    public string WaltAcctNmbr { get; set; } = null!;

    public decimal AvblBlnc { get; set; }

    public decimal? TotalBalance { get; set; }

    public decimal? Diff { get; set; }
}
