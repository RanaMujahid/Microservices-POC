using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Zone
{
    public int ZoneId { get; set; }

    public string ZoneCode { get; set; } = null!;

    public string ZoneName { get; set; } = null!;

    public string? Note { get; set; }

    public string ZoneLqdty { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
