using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefBenProf
{
    public long BenProfId { get; set; }

    public string? BenMembCode { get; set; }

    public string? BenName { get; set; }

    public string? BenIdType { get; set; }

    public string? BenIdNumb { get; set; }

    public string? PhonNo { get; set; }

    public int? LastUpdtCycleNum { get; set; }

    public DateTime? BenDob { get; set; }

    public long? OldSno { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? Notes { get; set; }
}
