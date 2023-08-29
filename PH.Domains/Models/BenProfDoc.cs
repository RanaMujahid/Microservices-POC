using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class BenProfDoc
{
    public long DocId { get; set; }

    public long BenProfId { get; set; }

    public long UpldDocId { get; set; }

    public int DocCycleId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? OrgId { get; set; }

    public virtual UpldDocDetl UpldDoc { get; set; } = null!;
}
