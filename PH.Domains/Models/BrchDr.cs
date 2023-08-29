using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class BrchDr
{
    public long BrchId { get; set; }

    public string Code { get; set; } = null!;

    public string OldBrchCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? NameLocal { get; set; }

    public string? BrchAdrs { get; set; }

    public bool? IsMainBrch { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? RegnId { get; set; }

    public int? OnyxBrchGrpId { get; set; }

    public string? Wrkqstts { get; set; }

    public string? LqdtyCode { get; set; }

    public string? GrpCode { get; set; }

    public string? MfloosSpclstName { get; set; }

    public string? CostCntr { get; set; }

    public int? ZoneId { get; set; }

    public string? BrchDao { get; set; }
}
