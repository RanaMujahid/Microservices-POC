using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AcctDoc
{
    public long DocId { get; set; }

    public long AcctId { get; set; }

    public long UpldDocId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Acct Acct { get; set; } = null!;

    public virtual UpldDocDetl UpldDoc { get; set; } = null!;
}
