using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class SuplZoneBlnc
{
    public long SuplZoneBlncId { get; set; }

    public long SuplBpMainId { get; set; }

    public int ZoneId { get; set; }

    public string ZoneBrch { get; set; } = null!;

    public decimal AvblBlnc { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
