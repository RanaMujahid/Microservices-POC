using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpCyclDetl
{
    public int CorpCyclDetlId { get; set; }

    public int CorpCyclId { get; set; }

    public decimal Fee { get; set; }

    public bool IsPrcntFee { get; set; }

    public decimal Cmsn { get; set; }

    public bool IsPrcntCmsn { get; set; }

    public string LoctType { get; set; } = null!;

    public string Liquidity { get; set; } = null!;

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual CorpCycl CorpCycl { get; set; } = null!;
}
