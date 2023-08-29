using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class GroupFeesDetl
{
    public int DetlId { get; set; }

    public int FeesGroupId { get; set; }

    public int FeesId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Fee Fees { get; set; } = null!;

    public virtual GroupFee FeesGroup { get; set; } = null!;
}
