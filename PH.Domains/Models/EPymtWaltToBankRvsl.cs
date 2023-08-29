﻿using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class EPymtWaltToBankRvsl
{
    public long EPymtWaltToBankRvslId { get; set; }

    public long TranTypeId { get; set; }

    public decimal Amount { get; set; }

    public decimal Fee { get; set; }

    public string DebtAcct { get; set; } = null!;

    public string CrdtAcct { get; set; } = null!;

    public long SendBpId { get; set; }

    public int SendZoneId { get; set; }

    public string? Desc { get; set; }

    public string? BankRfrncId { get; set; }

    public DateTime TranDate { get; set; }

    public string TranTypeCode { get; set; } = null!;

    public string ChnlTypeCode { get; set; } = null!;

    public bool? TranStts { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;
}
