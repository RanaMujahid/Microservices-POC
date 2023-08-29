using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefMmbrFlg
{
    public long MmbrFlgId { get; set; }

    public long? MmbrId { get; set; }

    public int? CycleId { get; set; }

    public int? OrgId { get; set; }

    public bool? FlgDeceasedNoPymt { get; set; }

    public bool? FlgReqCm { get; set; }

    public bool? FlgPayOnly { get; set; }

    public bool? FlgDisQualified { get; set; }

    public bool? FlgTakePhoto { get; set; }

    public bool? FlgVerfied { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
