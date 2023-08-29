using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class SubUserAlwdCrcy
{
    public long SubUserAlwdCrcyId { get; set; }

    public long UserBpMainId { get; set; }

    public string CrcyTypeCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
