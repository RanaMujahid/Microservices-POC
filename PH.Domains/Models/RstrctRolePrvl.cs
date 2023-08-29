using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class RstrctRolePrvl
{
    public long RstrctRolePrvlId { get; set; }

    public string RoleTypeCode { get; set; } = null!;

    public int MenuPrvlId { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual MenuPrvl MenuPrvl { get; set; } = null!;
}
