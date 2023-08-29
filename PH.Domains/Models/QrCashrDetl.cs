using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class QrCashrDetl
{
    public long QrCashrDetlId { get; set; }

    public string CashrCode { get; set; } = null!;

    public long CashrBpMainId { get; set; }

    public long QrMainId { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual BpMain CashrBpMain { get; set; } = null!;

    public virtual QrMain QrMain { get; set; } = null!;
}
