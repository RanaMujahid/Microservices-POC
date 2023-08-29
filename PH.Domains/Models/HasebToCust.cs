using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class HasebToCust
{
    public long MfToCustId { get; set; }

    public decimal Amount { get; set; }

    public decimal Fee { get; set; }

    public decimal Cmsn { get; set; }

    public string DebtAcct { get; set; } = null!;

    public string CrdtAcct { get; set; } = null!;

    public long PrfmrBpMainId { get; set; }

    public long RcvrBpMainId { get; set; }

    public string? Desc { get; set; }

    public string? PrfmrBrch { get; set; }

    public string? PrfmrLqdty { get; set; }

    public string? RcvrBrch { get; set; }

    public string? RcvrLqdty { get; set; }

    public decimal? CalcLqdtyFee { get; set; }

    public string? CalcLqdty { get; set; }

    public DateTime TranDate { get; set; }

    public string TranTypeCode { get; set; } = null!;

    public string ChnlTypeCode { get; set; } = null!;

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
