using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class HasebPymtT24DaoCorrection
{
    public long HasebPymtId { get; set; }

    public string DebtAcct { get; set; } = null!;

    public string CrdtAcct { get; set; } = null!;

    public decimal PymtAmnt { get; set; }

    public decimal FeeAmnt { get; set; }

    public decimal CmsnAmnt { get; set; }

    public int HasebPointNmbr { get; set; }

    public long PerformerId { get; set; }

    public DateTime PymtDate { get; set; }

    public DateTime? PymtRfndDate { get; set; }

    public long? PymtRfndBy { get; set; }

    public string PymtStts { get; set; } = null!;

    public int TranTypeCode { get; set; }

    public int ChnlTypeCode { get; set; }

    public long? PaydByQrCode { get; set; }

    public string? CustName { get; set; }

    public string? CustAcctType { get; set; }

    public string? BankAcctNmbr { get; set; }

    public string? PrfmrBrch { get; set; }

    public string? PrfmrLqdty { get; set; }

    public string? RcvrBrch { get; set; }

    public string? RcvrLqdty { get; set; }

    public string? SentLqdty { get; set; }

    public decimal? SentLqdtyFee { get; set; }

    public string? BankAcctBrch { get; set; }

    public string? Desc { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
