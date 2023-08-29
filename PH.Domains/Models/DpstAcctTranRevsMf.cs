using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class DpstAcctTranRevsMf
{
    public long AcctTranId { get; set; }

    public decimal Amnt { get; set; }

    public decimal AmntBaseCrcy { get; set; }

    public decimal AmntFrgnCrcy { get; set; }

    public string AmntTypeCode { get; set; } = null!;

    public decimal XchgRate { get; set; }

    public string DebtAcct { get; set; } = null!;

    public string CrdtAcct { get; set; } = null!;

    public long BsnsPrtnId { get; set; }

    public string? BpType { get; set; }

    public string OprnType { get; set; } = null!;

    public string SubOprnType { get; set; } = null!;

    public DateTime TranDate { get; set; }

    public string TranTypeCode { get; set; } = null!;

    public long TranTypeId { get; set; }

    public string CrcyCode { get; set; } = null!;

    public string SrceTypeCode { get; set; } = null!;

    public string TrgtTypeCode { get; set; } = null!;

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsPostedToAcct { get; set; }
}
