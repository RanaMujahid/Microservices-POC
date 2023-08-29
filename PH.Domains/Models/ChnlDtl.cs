﻿using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class ChnlDtl
{
    public int ChnlDtlId { get; set; }

    public int ChnlId { get; set; }

    public int CmsnPrflId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Chnl Chnl { get; set; } = null!;

    public virtual CmsnPrfl CmsnPrfl { get; set; } = null!;
}
