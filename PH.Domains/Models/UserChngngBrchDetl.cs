﻿using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UserChngngBrchDetl
{
    public long UserChngngBrchDetlId { get; set; }

    public long UserChngngBrchRqstId { get; set; }

    public long BpMainId { get; set; }

    public long BpSecId { get; set; }

    public string BpType { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual UserChngngBrchRqst UserChngngBrchRqst { get; set; } = null!;
}
