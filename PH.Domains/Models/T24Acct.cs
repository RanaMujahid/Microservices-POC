using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class T24Acct
{
    public string AcctId { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public string? AltAcctId { get; set; }

    public string? CustomerNo { get; set; }
}
