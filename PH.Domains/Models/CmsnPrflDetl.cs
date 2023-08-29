using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CmsnPrflDetl
{
    public int CmsnPrflDetlId { get; set; }

    public int CmsnPrflId { get; set; }

    public int TranId { get; set; }

    public int BsnsPrtnId { get; set; }

    public decimal CmsnPcnt { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? CmsnGroupId { get; set; }

    public virtual BsnsPrtn BsnsPrtn { get; set; } = null!;

    public virtual CmsnPrfl CmsnPrfl { get; set; } = null!;

    public virtual Tran Tran { get; set; } = null!;
}
