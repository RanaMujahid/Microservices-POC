using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpLoctActv
{
    public long CorpLoctActvId { get; set; }

    public long? BpMainId { get; set; }

    public long? BpSecId { get; set; }

    public long? CorpLoctId { get; set; }

    public int? CorpId { get; set; }

    public bool IsAsgnd { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual BpMain? BpMain { get; set; }

    public virtual Corp? Corp { get; set; }

    public virtual CorpLoct? CorpLoct { get; set; }
}
