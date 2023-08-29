using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class TempAgntAcct
{
    public string? CurrId { get; set; }

    public string Phon { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public long BpMainId { get; set; }

    public string AgntName { get; set; } = null!;

    public string BankAcctNo { get; set; } = null!;
}
