using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class EtiRemt
{
    public long RemtId { get; set; }

    public string? BenVeriCode { get; set; }

    public string? BenElecId { get; set; }

    public string? BenName { get; set; }

    public decimal? Amnt { get; set; }

    public int? CycleId { get; set; }

    public long? PayedBy { get; set; }

    public string? SttsTypeCode { get; set; }

    public long? PaydLoctId { get; set; }

    public long? PaydMmbrId { get; set; }

    public string? GovrntCode { get; set; }

    public string? DistrctCode { get; set; }

    public string? SchoolName { get; set; }

    public DateTime? ScheduledPaymentDate { get; set; }

    public bool? RequiresBankAccount { get; set; }

    public bool? NoPaymentFlag { get; set; }

    public bool? VerifiedFlag { get; set; }

    public bool? RequiresVerificationFormFlag { get; set; }

    public bool? EPaymentFlag { get; set; }

    public bool? IsPayedOffline { get; set; }

    public int? PayedChnl { get; set; }

    public string? SubAcct { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<EtiRemtDocRevw> EtiRemtDocRevws { get; set; } = new List<EtiRemtDocRevw>();

    public virtual ICollection<EtiRemtOffLine> EtiRemtOffLines { get; set; } = new List<EtiRemtOffLine>();
}
