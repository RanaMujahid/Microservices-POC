using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpDoc
{
    public long CorpDocId { get; set; }

    public long? DocId { get; set; }

    public long? CorpRemtId { get; set; }

    public string? ReviewStts { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual CorpRemt? CorpRemt { get; set; }

    public virtual UpldDocDetl? Doc { get; set; }
}
