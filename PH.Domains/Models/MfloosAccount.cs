using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class MfloosAccount
{
    public string CustomerName { get; set; } = null!;

    public string WaltAcctNmbr { get; set; } = null!;

    public string? IdNmbr { get; set; }

    public string Phon { get; set; } = null!;

    public string? SourceIncome { get; set; }

    public string LinkedBranch { get; set; } = null!;

    public DateTime RequestDate { get; set; }
}
