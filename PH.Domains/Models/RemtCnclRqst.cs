using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class RemtCnclRqst
{
    public long RemtId { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual Remt Remt { get; set; } = null!;
}
