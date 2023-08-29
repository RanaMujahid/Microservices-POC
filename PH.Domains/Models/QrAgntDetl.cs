using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class QrAgntDetl
{
    public long QrAgntDetlId { get; set; }

    public long OldAgntCode { get; set; }

    public long? AgntBpMainId { get; set; }

    public long QrMainId { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual BpMain? AgntBpMain { get; set; }

    public virtual QrMain QrMain { get; set; } = null!;
}
