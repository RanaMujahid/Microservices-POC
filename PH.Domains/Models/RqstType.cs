using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class RqstType
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? NameLocal { get; set; }

    public string? Desc { get; set; }

    public string PritTypeCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual PritType PritTypeCodeNavigation { get; set; } = null!;

    public virtual ICollection<RqstAprvDesg> RqstAprvDesgs { get; set; } = new List<RqstAprvDesg>();

    public virtual ICollection<WorkQue> WorkQues { get; set; } = new List<WorkQue>();
}
