using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CashWdrlDetl
{
    public long CashWdrlDetlId { get; set; }

    public long? CashWdrlId { get; set; }

    public long? BpMainId { get; set; }

    public int? PerformerId { get; set; }

    public decimal? Cmsn { get; set; }

    public string? ChnlTypeCode { get; set; }

    public string? TranTypeCode { get; set; }

    public string? CreditAcct { get; set; }

    public string? DebitAcct { get; set; }

    public long? SessionId { get; set; }

    public string? SessionCode { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public DateTime? BsnsOprnDate { get; set; }

    public virtual BpMain? BpMain { get; set; }

    public virtual CashWdrlMain? CashWdrl { get; set; }
}
