using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefRemtOffLine
{
    public long UnicefRemtOffLineId { get; set; }

    public long? RemtId { get; set; }

    public DateTime OffLinePaidDate { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual UnicefRemt? Remt { get; set; }
}
