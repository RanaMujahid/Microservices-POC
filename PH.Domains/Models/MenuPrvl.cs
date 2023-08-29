using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class MenuPrvl
{
    public int MenuPrvlId { get; set; }

    public string MenuPrvlName { get; set; } = null!;

    public string? MenuPrvlNameLocal { get; set; }

    public string? MenuPrvlDesc { get; set; }

    public string? ContName { get; set; }

    public string? ActnName { get; set; }

    public string? MenuParamName { get; set; }

    public string? MenuParamValue { get; set; }

    public int? PrntId { get; set; }

    public int SortOrdr { get; set; }

    public bool IsVsbl { get; set; }

    public string? Code { get; set; }

    public bool? IsMobl { get; set; }

    public string? IconName { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<RolePrvlDetl> RolePrvlDetls { get; set; } = new List<RolePrvlDetl>();

    public virtual ICollection<RstrctRolePrvl> RstrctRolePrvls { get; set; } = new List<RstrctRolePrvl>();

    public virtual ICollection<UsrPrvlDetl> UsrPrvlDetls { get; set; } = new List<UsrPrvlDetl>();
}
