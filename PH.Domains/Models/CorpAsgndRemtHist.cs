using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpAsgndRemtHist
{
    public long CorpAsgndRemtId { get; set; }

    public long BpMainId { get; set; }

    public long BpSecdId { get; set; }

    public long CorpRemtId { get; set; }

    public string AsgndStts { get; set; } = null!;

    public long? DocId { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
