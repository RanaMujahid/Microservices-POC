using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CustProfSetg
{
    public int CustProfSetgId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? NameLocal { get; set; }

    public string? Desc { get; set; }

    public string? CustTypeCode { get; set; }

    public int? KycSetId { get; set; }

    public int? LimtId { get; set; }

    public string? WrkqStts { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual CustType? CustTypeCodeNavigation { get; set; }

    public virtual KycSet? KycSet { get; set; }

    public virtual AgntLimtSetng? Limt { get; set; }
}
