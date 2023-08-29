using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class KeChnl
{
    public int KeChnlId { get; set; }

    public string KeChnlName { get; set; } = null!;

    public string? KeChnlNameLocal { get; set; }

    public string? KeChnlDesc { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
