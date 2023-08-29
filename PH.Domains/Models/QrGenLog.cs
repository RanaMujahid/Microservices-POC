using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class QrGenLog
{
    public int QrGenId { get; set; }

    public long AgntCode { get; set; }

    public string SttsTypeCode { get; set; } = null!;

    public string? FailResn { get; set; }

    public long DocId { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }
}
