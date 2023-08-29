using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefFileDoc
{
    public int UnicefFileDocId { get; set; }

    public long? DocId { get; set; }

    public int? OrgId { get; set; }

    public int? CycleId { get; set; }

    public string? FileTypeCode { get; set; }

    public string? StatusTypeCode { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
