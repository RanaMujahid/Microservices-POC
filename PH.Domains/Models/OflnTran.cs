using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class OflnTran
{
    public long OflnTranId { get; set; }

    public string TranTypeCode { get; set; } = null!;

    public long TranTypeId { get; set; }

    public DateTime TranDate { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
