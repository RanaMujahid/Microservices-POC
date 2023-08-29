using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpRemtInssDetl
{
    public long CorpRemtInssDetlId { get; set; }

    public long CorpRemtId { get; set; }

    public int CorpId { get; set; }

    public int CyclId { get; set; }

    public decimal InssAmnt { get; set; }

    public bool IsReFund { get; set; }

    public DateTime? TranDate { get; set; }

    public long AgntBpMainId { get; set; }

    public long? InssReqId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual BpMain AgntBpMain { get; set; } = null!;

    public virtual Corp Corp { get; set; } = null!;

    public virtual CorpRemt CorpRemt { get; set; } = null!;

    public virtual CorpCycl Cycl { get; set; } = null!;
}
