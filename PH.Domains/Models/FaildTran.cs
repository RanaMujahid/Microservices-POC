using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class FaildTran
{
    public long FaildTranId { get; set; }

    public long? RefrncId { get; set; }

    public string? SrvcPrvdrCode { get; set; }

    public string DebtAcct { get; set; } = null!;

    public string CrdtAcct { get; set; } = null!;

    public decimal PaidAmnt { get; set; }

    public decimal? Fee { get; set; }

    public decimal? FeeDiff { get; set; }

    public DateTime TranDate { get; set; }

    public int TranTypeCode { get; set; }

    public int ChnlTypeCode { get; set; }

    public long? PerformerId { get; set; }

    public bool IsPrcsd { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Chnl ChnlTypeCodeNavigation { get; set; } = null!;

    public virtual Acct DebtAcctNavigation { get; set; } = null!;

    public virtual BpMain? Performer { get; set; }

    public virtual Tran TranTypeCodeNavigation { get; set; } = null!;
}
