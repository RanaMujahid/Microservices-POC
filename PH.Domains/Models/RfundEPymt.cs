using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class RfundEPymt
{
    public long RfundEPymtId { get; set; }

    public string? PhTranId { get; set; }

    public string? SuplPymtId { get; set; }

    public decimal? RefundAmnt { get; set; }

    public decimal? Fee { get; set; }

    public string? DbtAcct { get; set; }

    public string? CrdtAcct { get; set; }

    public string? Notes { get; set; }

    public long? BatchId { get; set; }

    public string? T24RefNo { get; set; }

    public long? SessionId { get; set; }

    public string? SessionCode { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public DateTime? BsnsOprnDate { get; set; }

    public string? TranStts { get; set; }

    public virtual BpSysUser CreatedByNavigation { get; set; } = null!;
}
