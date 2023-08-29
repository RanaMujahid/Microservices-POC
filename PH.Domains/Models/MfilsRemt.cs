using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class MfilsRemt
{
    public long MfilsRemtId { get; set; }

    public string MfilsRemtNo { get; set; } = null!;

    public decimal Amnt { get; set; }

    public decimal? Fee { get; set; }

    public string? SttsTypeCode { get; set; }

    public string? Note { get; set; }

    public string? SndrBrch { get; set; }

    public string? SndrLqdty { get; set; }

    public string? RcvrBrch { get; set; }

    public string? RcvrLqdty { get; set; }

    public string? CalcLqdty { get; set; }

    public decimal? CalcLqdtyFee { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? PreprdBy { get; set; }
}
