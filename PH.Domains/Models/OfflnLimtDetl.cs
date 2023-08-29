using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class OfflnLimtDetl
{
    public int OfflnLimtDetlId { get; set; }

    public int OfflnLimtId { get; set; }

    public int TranTypeCode { get; set; }

    public int GnrlLimtId { get; set; }

    public int CustmLimtId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual GroupLimit CustmLimt { get; set; } = null!;

    public virtual GroupLimit GnrlLimt { get; set; } = null!;

    public virtual OfflnLimt OfflnLimt { get; set; } = null!;

    public virtual Tran TranTypeCodeNavigation { get; set; } = null!;
}
