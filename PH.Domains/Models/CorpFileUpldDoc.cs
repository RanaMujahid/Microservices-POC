using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpFileUpldDoc
{
    public int CorpFileUpldDocId { get; set; }

    public long? DocId { get; set; }

    public int? CorpId { get; set; }

    public int? CyclId { get; set; }

    public string? DocType { get; set; }

    public string? AprvStts { get; set; }

    public virtual Corp? Corp { get; set; }

    public virtual CorpCycl? Cycl { get; set; }

    public virtual UpldDocDetl? Doc { get; set; }
}
