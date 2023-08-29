using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UserDesgHrcy
{
    public int UserDesgHrcyId { get; set; }

    public string ChldDesgCode { get; set; } = null!;

    public string PrntDesgCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual UserDesgType ChldDesgCodeNavigation { get; set; } = null!;

    public virtual UserDesgType PrntDesgCodeNavigation { get; set; } = null!;
}
