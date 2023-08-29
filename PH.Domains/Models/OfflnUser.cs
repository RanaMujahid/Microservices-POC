﻿using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class OfflnUser
{
    public int OfflnUserId { get; set; }

    public long BpMainId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual BpMain BpMain { get; set; } = null!;
}
