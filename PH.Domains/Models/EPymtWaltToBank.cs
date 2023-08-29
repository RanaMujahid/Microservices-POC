using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class EPymtWaltToBank
{
    public long EPymtWaltToBankId { get; set; }

    public decimal Amnt { get; set; }

    public decimal Fee { get; set; }

    public decimal? LqdtyFee { get; set; }

    public string DebtWaltAcct { get; set; } = null!;

    public string CrdtBankAcct { get; set; } = null!;

    public string? BankCustName { get; set; }

    public string? BankRfrncId { get; set; }

    public long SndrBpId { get; set; }

    public int SendZoneId { get; set; }

    public string? Desc { get; set; }

    public string? PrfmrBrch { get; set; }

    public string? PrfmrLqdty { get; set; }

    public string? RcvrBrch { get; set; }

    public string? RcvrLqdty { get; set; }

    public int TranTypeCode { get; set; }

    public int ChnlTypeCode { get; set; }

    public DateTime TranDate { get; set; }

    public string? TranStts { get; set; }

    public int RetryCount { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long? BatchId { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public DateTime? BsnsOprnDate { get; set; }
}
