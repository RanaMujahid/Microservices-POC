using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class LdgrCnfg
{
    public int LdgrCnfgId { get; set; }

    public int TranTypeCode { get; set; }

    public string FnanAcctCtgryCodeDr { get; set; } = null!;

    public string FnanAcctCtgryCodeCr { get; set; } = null!;

    public string AmntTypeCode { get; set; } = null!;

    public string? RevnPrtnTypeCode { get; set; }

    public string? DrLdgrDescEn { get; set; }

    public string? DrLdgrDescAr { get; set; }

    public string? CrLdgrDescEn { get; set; }

    public string? CrLdgrDescAr { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string AcctType { get; set; } = null!;
}
