using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UserChngngBrchRqst
{
    public long UserChngngBrchRqstId { get; set; }

    public long BpMainId { get; set; }

    public string BpType { get; set; } = null!;

    public string OldBrchCode { get; set; } = null!;

    public string OldBrchLqdty { get; set; } = null!;

    public string NewBrchCode { get; set; } = null!;

    public string NewBrchLqdty { get; set; } = null!;

    public string SttsTypeCode { get; set; } = null!;

    public decimal UserAvlbBlnc { get; set; }

    public long PrfmrBpMainId { get; set; }

    public long TotlTransCount { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual BpMain BpMain { get; set; } = null!;

    public virtual ICollection<UserChngngBrchDetl> UserChngngBrchDetls { get; set; } = new List<UserChngngBrchDetl>();

    public virtual ICollection<UserChngngBrchDoc> UserChngngBrchDocs { get; set; } = new List<UserChngngBrchDoc>();
}
