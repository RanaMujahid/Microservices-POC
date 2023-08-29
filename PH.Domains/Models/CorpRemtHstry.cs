using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpRemtHstry
{
    public long CorpRemtHstryId { get; set; }

    public long CorpRemtId { get; set; }

    public string SttsTypeCode { get; set; } = null!;

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public virtual CorpRemt CorpRemt { get; set; } = null!;
}
