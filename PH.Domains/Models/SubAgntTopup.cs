﻿using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class SubAgntTopup
{
    public long SubAgntTopupId { get; set; }

    public decimal Amount { get; set; }

    public decimal Fee { get; set; }

    public decimal Cmsn { get; set; }

    public string DebtAcct { get; set; } = null!;

    public string CrdtAcct { get; set; } = null!;

    public long SndrBpId { get; set; }

    public long RcvrBpId { get; set; }

    public string? Desc { get; set; }

    public DateTime TranDate { get; set; }

    public string TranTypeCode { get; set; } = null!;

    public string ChnlTypeCode { get; set; } = null!;

    public string ClntRoleTypeCode { get; set; } = null!;

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
