using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class FeeDetl
{
    public int FeeDetlId { get; set; }

    public decimal? RngeStrt { get; set; }

    public decimal? RngeEnd { get; set; }

    public decimal? MinFee { get; set; }

    public decimal? MaxFee { get; set; }

    public decimal? Pcnt { get; set; }

    public decimal? Incr { get; set; }

    public decimal? IncrFee { get; set; }

    public int? FeeId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? Lqdty { get; set; }

    public string? FeePerdTypeCode { get; set; }

    public virtual Fee? Fee { get; set; }
}
