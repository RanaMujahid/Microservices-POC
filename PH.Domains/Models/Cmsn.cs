using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Cmsn
{
    public int CmsnId { get; set; }

    public string CmsnName { get; set; } = null!;

    public string? CmsnNameLocal { get; set; }

    public string? CmsnDesc { get; set; }

    public string CmsnCalcTypeCode { get; set; } = null!;

    public string? CrcyTypeCode { get; set; }

    public int? TierDtrmBy { get; set; }

    public int? PcntCalcOn { get; set; }

    public string? CmsnPerdTypeCode { get; set; }

    public decimal? FlatCmsn { get; set; }

    public string? StatusTypeCode { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual CmsnCalcType CmsnCalcTypeCodeNavigation { get; set; } = null!;

    public virtual ICollection<CmsnDay> CmsnDays { get; set; } = new List<CmsnDay>();

    public virtual ICollection<CmsnDetl> CmsnDetls { get; set; } = new List<CmsnDetl>();

    public virtual CmsnPerdType? CmsnPerdTypeCodeNavigation { get; set; }

    public virtual CrcyType? CrcyTypeCodeNavigation { get; set; }
}
