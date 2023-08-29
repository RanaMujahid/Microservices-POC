using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class TempAcctRev
{
    public string WaltAcctNmbr { get; set; } = null!;

    public decimal AvblBlncBefr { get; set; }

    public decimal? Amnt { get; set; }

    public DateTime CreatedOn { get; set; }

    public string Orgn { get; set; } = null!;
}
