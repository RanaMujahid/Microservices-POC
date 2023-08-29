using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpAsgndRemt
{
    public long CorpAsgndRemtId { get; set; }

    public int CorpId { get; set; }

    public int CorpCyclId { get; set; }

    public long BpMainId { get; set; }

    public long BpSecdId { get; set; }

    public long CorpRemtId { get; set; }

    public long? DocId { get; set; }

    public bool? IsDownloaded { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
