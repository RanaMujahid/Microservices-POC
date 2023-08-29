using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class VwbillPaymentCombined
{
    public long Pkpymtid { get; set; }

    public string Debtacct { get; set; } = null!;

    public string Crdtacct { get; set; } = null!;

    public decimal Paidamnt { get; set; }

    public decimal? Feeamnt { get; set; }

    public decimal? Cmsnamnt { get; set; }

    public string Mbilenmbr { get; set; } = null!;

    public long Prfmrid { get; set; }

    public DateTime Trandate { get; set; }

    public int Trantypecode { get; set; }

    public int Chnltypecode { get; set; }

    public string Areacode { get; set; } = null!;

    public long Scribrnmbr { get; set; }

    public string Offrcode { get; set; } = null!;

    public string? Offrname { get; set; }

    public decimal? Offrprice { get; set; }

    public int? Pymttype { get; set; }

    public decimal? Amntunit { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public decimal? ExtraFeeAmnt { get; set; }

    public string? ChrgdLqdty { get; set; }

    public decimal? OrgnAmnt { get; set; }
}
