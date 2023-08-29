using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class LimtDetl
{
    public int LimtDetlId { get; set; }

    public int LimtId { get; set; }

    public string? CrcyTypeCode { get; set; }

    public decimal? MinAmnt { get; set; }

    public decimal? MaxAmnt { get; set; }

    public bool? IsUnLmtd { get; set; }

    public int? MaxTranCnt { get; set; }

    public string? LimtPerdType { get; set; }

    public bool? IsNdvd { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? Lqdty { get; set; }

    public virtual CrcyType? CrcyTypeCodeNavigation { get; set; }

    public virtual Limt Limt { get; set; } = null!;

    public virtual LimtPerdType? LimtPerdTypeNavigation { get; set; }
}
