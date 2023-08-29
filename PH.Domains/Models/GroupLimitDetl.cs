using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class GroupLimitDetl
{
    public int DetlId { get; set; }

    public int LimitGroupId { get; set; }

    public int LimitId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Limt Limit { get; set; } = null!;

    public virtual GroupLimit LimitGroup { get; set; } = null!;
}
