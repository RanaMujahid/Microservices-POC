using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class BillMtnPkgPymt
{
    public long BillMtnPkgPymtId { get; set; }

    public string DebtAcct { get; set; } = null!;

    public string CrdtAcct { get; set; } = null!;

    public decimal PaidAmnt { get; set; }

    public string CustMoblNo { get; set; } = null!;

    public long PerformerId { get; set; }

    public DateTime TranDate { get; set; }

    public int TranTypeCode { get; set; }

    public int ChnlTypeCode { get; set; }

    public decimal? FeeAmnt { get; set; }

    public decimal? ExtraFeeAmnt { get; set; }

    public string? ChrgdLqdty { get; set; }

    public decimal? OrgnAmnt { get; set; }

    public decimal? CmsnAmnt { get; set; }

    public string OffrCode { get; set; } = null!;

    public string? OffrName { get; set; }

    public decimal? OffrPric { get; set; }

    public string? HostDvicId { get; set; }

    public string? IpHostAdd { get; set; }

    public long? RfrncId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? PymtType { get; set; }

    public string? TranStts { get; set; }

    public virtual Chnl ChnlTypeCodeNavigation { get; set; } = null!;

    public virtual Acct CrdtAcctNavigation { get; set; } = null!;

    public virtual Acct DebtAcctNavigation { get; set; } = null!;

    public virtual Tran TranTypeCodeNavigation { get; set; } = null!;
}
