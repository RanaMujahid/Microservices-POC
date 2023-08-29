using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CnclChrg
{
    public int CnclChrgId { get; set; }

    public string? TransTypeCode { get; set; }

    public decimal? CnclChrgPercnt { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    public long? SessionId { get; set; }

    public string? SessionCode { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
