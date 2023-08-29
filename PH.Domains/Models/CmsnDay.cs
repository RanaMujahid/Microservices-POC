using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CmsnDay
{
    public int CmsnDaysId { get; set; }

    public bool? Mon { get; set; }

    public bool? Tue { get; set; }

    public bool? Wed { get; set; }

    public bool? Thu { get; set; }

    public bool? Fri { get; set; }

    public bool? Sat { get; set; }

    public bool? Sun { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? FromTime { get; set; }

    public string? ToTime { get; set; }

    public int CmsnId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Cmsn Cmsn { get; set; } = null!;
}
