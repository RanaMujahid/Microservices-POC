using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class DpstMfToMf
{
    public long DpstMfToMfId { get; set; }

    public string DebtAcct { get; set; } = null!;

    public string CrdtAcct { get; set; } = null!;

    public string SndrName { get; set; } = null!;

    public string RcvrName { get; set; } = null!;

    public decimal Amnt { get; set; }

    public decimal Fee { get; set; }

    public decimal Cmsn { get; set; }

    public long SndrBpId { get; set; }

    public long RcvrBpId { get; set; }

    public long DpstFileDocId { get; set; }

    public string? Cmnts { get; set; }

    public string? Notes { get; set; }

    public long? PrfmrId { get; set; }

    public string? PrfmrBrch { get; set; }

    public string? PrfmrLqdty { get; set; }

    public string? RcvrBrch { get; set; }

    public string? RcvrLqdty { get; set; }

    public string? TranStts { get; set; }

    public DateTime TranDate { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
