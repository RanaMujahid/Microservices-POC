using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class RefundEPaymt
{
    public long RefundEPaymtId { get; set; }

    public string MovementType { get; set; } = null!;

    public decimal TotalAmount { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public bool IsRefund { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
