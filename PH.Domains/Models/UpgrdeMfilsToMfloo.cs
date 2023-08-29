using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UpgrdeMfilsToMfloo
{
    public long UpgrdAcctId { get; set; }

    public long MfilsAcctId { get; set; }

    public long MfloosAcctId { get; set; }

    public decimal MfilsAvblBlnc { get; set; }

    public string? CalcLqdty { get; set; }

    public decimal CalcLqdtyFee { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
