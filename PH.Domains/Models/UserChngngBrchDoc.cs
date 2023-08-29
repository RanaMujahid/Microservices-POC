using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UserChngngBrchDoc
{
    public long UserChngngBrchDocId { get; set; }

    public long UserChngngBrchRqstId { get; set; }

    public long UplcDocId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual UserChngngBrchRqst UserChngngBrchRqst { get; set; } = null!;
}
