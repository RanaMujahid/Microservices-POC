using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class SuprAgntDoc
{
    public long SuprAgntDocId { get; set; }

    public long DocId { get; set; }

    public int SuprAgntId { get; set; }

    public virtual SuprAgnt SuprAgnt { get; set; } = null!;
}
