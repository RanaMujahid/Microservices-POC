using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefRemtFlgOutReach
{
    public long RemtFlgOutReachId { get; set; }

    public long? RemtId { get; set; }

    public bool? IsFlgOutReachRemt { get; set; }

    public bool? FlgOutReachVal { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual UnicefRemt? Remt { get; set; }
}
