using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class PhGamCntyMap
{
    public long PhGamCntyMapId { get; set; }

    public string PhCntyCode { get; set; } = null!;

    public string GamCntyCode { get; set; } = null!;

    public long? SessionId { get; set; }

    public string? SessionCode { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
