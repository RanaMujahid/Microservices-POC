using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class MfilsRemtDetl
{
    public long MfilsRemtDetlId { get; set; }

    public long MfilsRemtId { get; set; }

    public int SndrBpId { get; set; }

    public decimal? CmsnAmnt { get; set; }

    public string ChnlTypeCode { get; set; } = null!;

    public string TranTypeCode { get; set; } = null!;

    public string? CreditAcct { get; set; }

    public string? DebitAcct { get; set; }

    public long? BenfBpMainId { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
