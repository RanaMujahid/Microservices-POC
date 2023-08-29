using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class RefundEPaymtDetl
{
    public long RefundEPaymtDetlId { get; set; }

    public long RefundEPaymentsId { get; set; }

    public string SubAcct { get; set; } = null!;

    public DateTime DepositDate { get; set; }

    public decimal Amount { get; set; }

    public string BenVeriCode { get; set; } = null!;

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
