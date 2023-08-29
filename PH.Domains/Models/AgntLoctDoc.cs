using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AgntLoctDoc
{
    public long LoctDocId { get; set; }

    public string? LoctDocType { get; set; }

    public long LoctId { get; set; }

    public long UpldDocId { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual AgntLoct Loct { get; set; } = null!;

    public virtual UpldDocDetl UpldDoc { get; set; } = null!;
}
