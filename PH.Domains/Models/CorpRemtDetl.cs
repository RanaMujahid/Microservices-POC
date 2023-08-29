using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpRemtDetl
{
    public long CorpRemtDetlId { get; set; }

    public long CorpRemtId { get; set; }

    public long? PerformerBpmainId { get; set; }

    public decimal? RemtAmnt { get; set; }

    public decimal? FeeAmnt { get; set; }

    public decimal? CmsnAmnt { get; set; }

    public decimal? InsuAmnt { get; set; }

    public decimal? LqdtyFee { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int? CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual CorpRemt CorpRemt { get; set; } = null!;

    public virtual BpMain? PerformerBpmain { get; set; }
}
