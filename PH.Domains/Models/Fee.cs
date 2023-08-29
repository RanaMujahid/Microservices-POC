using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Fee
{
    public int FeeId { get; set; }

    public string FeeName { get; set; } = null!;

    public string? FeeNameLocal { get; set; }

    public string FeeStts { get; set; } = null!;

    public string? FeeDesc { get; set; }

    public string CrcyTypeCode { get; set; } = null!;

    public string FeeCalcTypeCode { get; set; } = null!;

    public decimal? FlatFee { get; set; }

    public string? FeePerdTypeCode { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual CrcyType CrcyTypeCodeNavigation { get; set; } = null!;

    public virtual FeeCalcType FeeCalcTypeCodeNavigation { get; set; } = null!;

    public virtual ICollection<FeeDetl> FeeDetls { get; set; } = new List<FeeDetl>();

    public virtual FeePerdType? FeePerdTypeCodeNavigation { get; set; }

    public virtual RqstSttsType FeeSttsNavigation { get; set; } = null!;

    public virtual ICollection<GroupFeesDetl> GroupFeesDetls { get; set; } = new List<GroupFeesDetl>();
}
