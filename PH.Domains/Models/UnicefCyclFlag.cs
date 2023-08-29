using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefCyclFlag
{
    public int CyclFlagCode { get; set; }

    public int? FlagCode { get; set; }

    public int CyclId { get; set; }

    public string? CyclName { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Cycl Cycl { get; set; } = null!;

    public virtual UnicefFileFlag? FlagCodeNavigation { get; set; }
}
