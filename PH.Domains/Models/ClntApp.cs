using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class ClntApp
{
    public string AppId { get; set; } = null!;

    public string AppCode { get; set; } = null!;

    public string AppName { get; set; } = null!;

    public string? AppDesc { get; set; }

    public string AppScrt { get; set; } = null!;

    public string? AppVer { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsVerForced { get; set; }

    public bool? InMntnce { get; set; }
}
