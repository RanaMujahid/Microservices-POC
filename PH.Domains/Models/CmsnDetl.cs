using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CmsnDetl
{
    public int CmsnDetlId { get; set; }

    public decimal? RngeStrt { get; set; }

    public decimal? RngeEnd { get; set; }

    public decimal? MinCmsn { get; set; }

    public decimal? MaxCmsn { get; set; }

    public decimal? Pcnt { get; set; }

    public int CmsnId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? Lqdty { get; set; }

    public string? PerdTypeCode { get; set; }

    public bool? IsPcnt { get; set; }

    public virtual Cmsn Cmsn { get; set; } = null!;
}
