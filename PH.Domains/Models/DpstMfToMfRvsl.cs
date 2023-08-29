using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class DpstMfToMfRvsl
{
    public long DpstMfToMfRvslId { get; set; }

    public long DpstMfToMfId { get; set; }

    public string DebtAcct { get; set; } = null!;

    public string CrdtAcct { get; set; } = null!;

    public decimal Amount { get; set; }

    public decimal Fee { get; set; }

    public decimal? Cmsn { get; set; }

    public DateTime DpstTranDate { get; set; }

    public DateTime TranDate { get; set; }

    public string TranTypeCode { get; set; } = null!;

    public long PrfmrId { get; set; }
}
