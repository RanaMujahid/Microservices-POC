using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class BillElctPymt
{
    public long BillElctPymtId { get; set; }

    public decimal PaidAmnt { get; set; }

    public string AreaCode { get; set; } = null!;

    public long SbcnNmbr { get; set; }

    public string DebtAcct { get; set; } = null!;

    public string CrdtAcct { get; set; } = null!;

    public long PerformerId { get; set; }

    public DateTime TranDate { get; set; }

    public int TranTypeCode { get; set; }

    public int ChnlTypeCode { get; set; }

    public decimal? FeeAmnt { get; set; }

    public string? ChrgdLqdty { get; set; }

    public decimal? OrgnAmnt { get; set; }

    public decimal? CmsnAmnt { get; set; }

    public string? HostDvicId { get; set; }

    public string? IpHostAddr { get; set; }

    public long? RfrncId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? TranStts { get; set; }

    public virtual Chnl ChnlTypeCodeNavigation { get; set; } = null!;

    public virtual Acct CrdtAcctNavigation { get; set; } = null!;

    public virtual Acct DebtAcctNavigation { get; set; } = null!;

    public virtual BpMain Performer { get; set; } = null!;

    public virtual Tran TranTypeCodeNavigation { get; set; } = null!;
}
