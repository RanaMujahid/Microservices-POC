using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CmsnDistDetl
{
    public long CmsnDistDetlId { get; set; }

    public long TranId { get; set; }

    public string? TranTypeCode { get; set; }

    public string? BsnsPrtnType { get; set; }

    public string AcctNo { get; set; } = null!;

    public decimal CmsnAmnt { get; set; }

    public decimal Pcnt { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }
}
