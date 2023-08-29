using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CmsnGroup
{
    public int CmsnGroupId { get; set; }

    public string CmsnGroupName { get; set; } = null!;

    public string? CmsnGroupNameLocal { get; set; }

    public string? Desc { get; set; }

    public string? StatusTypeCode { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
