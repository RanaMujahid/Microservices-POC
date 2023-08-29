using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class FrzAcctDoc
{
    public long FrzAcctDocId { get; set; }

    public long DocId { get; set; }

    public long FrzAcctId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual FrzAcct FrzAcct { get; set; } = null!;

    public virtual UpldDocDetl FrzAcctDocNavigation { get; set; } = null!;
}
