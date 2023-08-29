using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class EtiRemtDocRevw
{
    public long EtiRemtDocRevwId { get; set; }

    public long RemtId { get; set; }

    public string BenVeriCode { get; set; } = null!;

    public int? DocCycleId { get; set; }

    public string? RevwStts { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? RevwBy { get; set; }

    public virtual EtiRemt Remt { get; set; } = null!;

    public virtual BpSysUser? RevwByNavigation { get; set; }
}
