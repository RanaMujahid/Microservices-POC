using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class MfT24AcctUpdate
{
    public int AcctId { get; set; }

    public int BpMainId { get; set; }

    public int BankAcctNmbr { get; set; }

    public int WaltAcctNmbr { get; set; }

    public double AvblBlnc { get; set; }

    public int IsActive { get; set; }

    public int BankAcctNo { get; set; }
}
