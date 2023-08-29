using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class TranInptSetng
{
    public int TranInptSetngId { get; set; }

    public string TranInptSetngName { get; set; } = null!;

    public string? TranInptSetngNameLocl { get; set; }

    public string? TranInptSetngDesc { get; set; }

    public int? TranId { get; set; }

    public int? KycSetId { get; set; }

    public string? WrkqStts { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Tran? Tran { get; set; }
}
