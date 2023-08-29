﻿using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class WorkHour
{
    public long WorkHourId { get; set; }

    public string OrgCode { get; set; } = null!;

    public TimeSpan StrtTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? CyclId { get; set; }
}
