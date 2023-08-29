using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class BillRegn
{
    public long BillRegnCode { get; set; }

    public long? RegnOldCode { get; set; }

    public string? RegnName { get; set; }

    public string? RegnNameLocal { get; set; }

    public string? Desc { get; set; }

    public string? SrvcPrvdrCode { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? LqdtyCode { get; set; }
}
