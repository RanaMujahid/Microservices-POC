using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AgntPrftSetngDetl
{
    public int AgntPrftSetngDetlId { get; set; }

    public int AgntPrftSetngId { get; set; }

    public int TranTypeCode { get; set; }

    public decimal FeePrcnt { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public decimal? SuprAgntFeePrcnt { get; set; }
}
