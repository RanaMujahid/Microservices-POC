using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class RefundEPymtBatch
{
    public long BatchId { get; set; }

    public long DocId { get; set; }

    public long SuplBpMainId { get; set; }

    public string Status { get; set; } = null!;

    public int TotalRcrd { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual BpSysUser CreatedByNavigation { get; set; } = null!;

    public virtual UpldDocDetl Doc { get; set; } = null!;

    public virtual ICollection<RefundEPymtBatchDetl> RefundEPymtBatchDetls { get; set; } = new List<RefundEPymtBatchDetl>();
}
