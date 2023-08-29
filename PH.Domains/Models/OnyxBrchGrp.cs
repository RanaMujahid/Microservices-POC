using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class OnyxBrchGrp
{
    public int OnyxBrchGrpId { get; set; }

    public string OnyxBrchGrpNumb { get; set; } = null!;

    public string CostCenter { get; set; } = null!;

    public string SourceSysCode { get; set; } = null!;

    public bool? IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    public long? SessionId { get; set; }

    public string? SessionCode { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
