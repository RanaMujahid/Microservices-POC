using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class FnanAcctCnfg
{
    public int FnanAcctId { get; set; }

    public string AcctNo { get; set; } = null!;

    public string AcctTitleEn { get; set; } = null!;

    public string? AcctTitleAr { get; set; }

    public string FnanAcctCtgryCode { get; set; } = null!;

    public string CrcyCode { get; set; } = null!;

    public int ZoneId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
