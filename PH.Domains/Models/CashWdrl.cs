using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CashWdrl
{
    public long CashWdrlId { get; set; }

    public long BpMainId { get; set; }

    public int TrgtAgntCode { get; set; }

    public decimal WdrlAmnt { get; set; }

    public decimal Fee { get; set; }

    public decimal? Cmsn { get; set; }

    public string? Debtacct { get; set; }

    public string? OprnCode { get; set; }

    public string? Note { get; set; }

    public string SttsTypeCode { get; set; } = null!;

    public bool? IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    public long? SessionId { get; set; }

    public string? SessionCode { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual BpMain BpMain { get; set; } = null!;

    public virtual FinReqSttsType SttsTypeCodeNavigation { get; set; } = null!;
}
