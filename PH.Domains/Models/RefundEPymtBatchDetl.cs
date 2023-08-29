using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class RefundEPymtBatchDetl
{
    public long BatchDetlId { get; set; }

    public long PhTranId { get; set; }

    public long? SuplPymtId { get; set; }

    public decimal RefundAmnt { get; set; }

    public decimal? Fee { get; set; }

    public DateTime? TranDate { get; set; }

    public string? Notes { get; set; }

    public long BatchId { get; set; }

    public string Status { get; set; } = null!;

    public string? ErrorMsg { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual RefundEPymtBatch Batch { get; set; } = null!;

    public virtual BpSysUser CreatedByNavigation { get; set; } = null!;
}
