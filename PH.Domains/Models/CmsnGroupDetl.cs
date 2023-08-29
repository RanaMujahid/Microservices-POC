using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CmsnGroupDetl
{
    public int CmsnGroupDetlId { get; set; }

    public int CmsnGroupId { get; set; }

    public int CmsnId { get; set; }

    public string CrcyTypeCode { get; set; } = null!;

    public string Lqdty { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
