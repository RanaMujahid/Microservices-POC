﻿using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class EPymtKjLimt
{
    public long EPymtKjLimtId { get; set; }

    public decimal TranLimtAmt { get; set; }

    public int DailyLimtCnt { get; set; }

    public decimal DailyLimtAmt { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
