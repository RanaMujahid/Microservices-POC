using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class RolePrvlDetl
{
    public int RolePrvlDetlId { get; set; }

    public string RoleTypeCode { get; set; } = null!;

    public int MenuPrvlId { get; set; }

    public virtual MenuPrvl MenuPrvl { get; set; } = null!;

    public virtual UserRoleType RoleTypeCodeNavigation { get; set; } = null!;
}
