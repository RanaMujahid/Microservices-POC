using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class EPymtWaltToBankBatchDetl
{
    public long BatchDetlId { get; set; }

    public long AcctNo { get; set; }

    public decimal Amnt { get; set; }

    public string? Notes { get; set; }

    public string? ErrorMsg { get; set; }

    public string Status { get; set; } = null!;

    public long BatchId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
