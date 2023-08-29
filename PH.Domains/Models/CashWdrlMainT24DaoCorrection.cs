using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CashWdrlMainT24DaoCorrection
{
    public long CashWdrlId { get; set; }

    public string? CashWdrlNo { get; set; }

    public int? TrgtAgntCode { get; set; }

    public decimal? Amnt { get; set; }

    public decimal? Fee { get; set; }

    public string? Note { get; set; }

    public string? SttsTypeCode { get; set; }

    public string? CustName { get; set; }

    public string? CustAcctType { get; set; }

    public string? BankAcctNmbr { get; set; }

    public string? BankAcctBrchDao { get; set; }

    public string? PrfmrBrch { get; set; }

    public string? PrfmrLqdty { get; set; }

    public string? RcvrBrch { get; set; }

    public string? RcvrLqdty { get; set; }

    public string? SentLqdty { get; set; }

    public decimal? SentLqdtyFee { get; set; }

    public string? PayLqdty { get; set; }

    public decimal? PayLqdtyFee { get; set; }

    public long? SessionId { get; set; }

    public string? SessionCode { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public long? PaydByQrCode { get; set; }
}
