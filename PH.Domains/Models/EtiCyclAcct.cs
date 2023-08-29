using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class EtiCyclAcct
{
    public long EtiCyclAcctsId { get; set; }

    public int CyclId { get; set; }

    public long AcctId { get; set; }

    public string BenVeriCode { get; set; } = null!;

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? AcctSubType { get; set; }
}
