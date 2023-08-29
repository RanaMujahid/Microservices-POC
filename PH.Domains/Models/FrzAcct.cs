using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class FrzAcct
{
    public long Id { get; set; }

    public long Acctid { get; set; }

    public decimal? FrzAmount { get; set; }

    public string FrzResnTypeCode { get; set; } = null!;

    public string FrzReqTypeCode { get; set; } = null!;

    public DateTime FrzDate { get; set; }

    public string? Note { get; set; }

    public bool? IsFreezedAll { get; set; }

    public bool? IsCanceledAll { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Acct Acct { get; set; } = null!;

    public virtual ICollection<FrzAcctDoc> FrzAcctDocs { get; set; } = new List<FrzAcctDoc>();

    public virtual FrzReqType FrzReqTypeCodeNavigation { get; set; } = null!;

    public virtual FrzResnType FrzResnTypeCodeNavigation { get; set; } = null!;
}
