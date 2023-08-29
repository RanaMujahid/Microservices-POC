using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class EPymtPrmtn
{
    public long EPymtPrmtnId { get; set; }

    public string Name { get; set; } = null!;

    public string? NameLocal { get; set; }

    public string? Notes { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public int GroupFeeId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
