using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AgntAsgnLoct
{
    public long AsgnLoctId { get; set; }

    public int BpSecdId { get; set; }

    public int BpMainId { get; set; }

    public long LoctId { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? OrgId { get; set; }

    public virtual AgntLoct Loct { get; set; } = null!;
}
