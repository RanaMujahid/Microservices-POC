using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Remt
{
    public long RemtId { get; set; }

    public string RemtNo { get; set; } = null!;

    public decimal Amnt { get; set; }

    public decimal? Fee { get; set; }

    public string? SttsTypeCode { get; set; }

    public string? Note { get; set; }

    public string? PrfmrBrch { get; set; }

    public string? PrfmrLqdty { get; set; }

    public string? RcvrBrch { get; set; }

    public string? RcvrLqdty { get; set; }

    public string? PayLqdty { get; set; }

    public decimal? PayLqdtyFee { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? PreprdBy { get; set; }

    public virtual ICollection<RemtBenfDetl> RemtBenfDetls { get; set; } = new List<RemtBenfDetl>();

    public virtual RemtCnclRqst? RemtCnclRqst { get; set; }

    public virtual ICollection<RemtDetl> RemtDetls { get; set; } = new List<RemtDetl>();
}
