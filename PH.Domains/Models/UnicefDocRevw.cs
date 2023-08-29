using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefDocRevw
{
    public long UnicefDocRevwId { get; set; }

    public long? DocId { get; set; }

    public string? RevwStts { get; set; }

    public long? RevwBy { get; set; }

    public string? Cmnt { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
