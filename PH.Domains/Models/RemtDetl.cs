using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class RemtDetl
{
    public long RemtDetlId { get; set; }

    public long RemtId { get; set; }

    public int PerformerId { get; set; }

    public decimal? CmsnAmnt { get; set; }

    public string ChnlTypeCode { get; set; } = null!;

    public string TranTypeCode { get; set; } = null!;

    public string? CreditAcct { get; set; }

    public string? DebitAcct { get; set; }

    public long? BpMainId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Remt Remt { get; set; } = null!;
}
