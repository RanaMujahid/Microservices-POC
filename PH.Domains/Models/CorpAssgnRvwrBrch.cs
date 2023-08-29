using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpAssgnRvwrBrch
{
    public long CorpAssgnRvwrBrchId { get; set; }

    public int CorpId { get; set; }

    public int CorpCyclId { get; set; }

    public long RvwrId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
