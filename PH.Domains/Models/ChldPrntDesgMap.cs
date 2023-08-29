using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class ChldPrntDesgMap
{
    public long PrntChldDesgMapId { get; set; }

    public int ChldId { get; set; }

    public string ChldDesg { get; set; } = null!;

    public int PrntId { get; set; }

    public string PrntDesg { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual BpSysUser Chld { get; set; } = null!;

    public virtual UserDesgType ChldDesgNavigation { get; set; } = null!;

    public virtual BpSysUser Prnt { get; set; } = null!;

    public virtual UserDesgType PrntDesgNavigation { get; set; } = null!;
}
