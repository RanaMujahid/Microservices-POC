using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AgntLimtSetng
{
    public int AgntLimtSetngId { get; set; }

    public string LimtSetngName { get; set; } = null!;

    public string? LimtSetngNameLocl { get; set; }

    public string? LimtSetngDesc { get; set; }

    public string? LimtSetngStts { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<AgntLimtSetngDetl> AgntLimtSetngDetls { get; set; } = new List<AgntLimtSetngDetl>();

    public virtual ICollection<AgntLimt> AgntLimts { get; set; } = new List<AgntLimt>();

    public virtual ICollection<CustProfSetg> CustProfSetgs { get; set; } = new List<CustProfSetg>();
}
