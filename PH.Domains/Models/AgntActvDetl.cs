using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AgntActvDetl
{
    public int AgntActvDetlId { get; set; }

    public string AgntActvCode { get; set; } = null!;

    public int AgntId { get; set; }

    public decimal? Age { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Agnt Agnt { get; set; } = null!;

    public virtual AgntActv AgntActvCodeNavigation { get; set; } = null!;
}
