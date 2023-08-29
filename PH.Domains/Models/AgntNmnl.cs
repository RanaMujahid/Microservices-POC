﻿using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AgntNmnl
{
    public int AgntNmnlId { get; set; }

    public string AgntNmnlName { get; set; } = null!;

    public string PhneNo { get; set; } = null!;

    public int AgntId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Agnt Agnt { get; set; } = null!;
}
