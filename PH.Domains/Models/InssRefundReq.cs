using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class InssRefundReq
{
    public long InssRefundReqId { get; set; }

    public int AgntId { get; set; }

    public decimal Amnt { get; set; }

    public string? SttsTypeCode { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
