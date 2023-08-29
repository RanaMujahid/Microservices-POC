using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpRemt02jan22
{
    public long CorpRemtId { get; set; }

    public int CorpId { get; set; }

    public int CorpCyclId { get; set; }

    public string? CardNmbr { get; set; }

    public string? FinaNmbr { get; set; }

    public string? RcvrName { get; set; }

    public string? SndrName { get; set; }

    public decimal? Amnt { get; set; }

    public string? Cmnt { get; set; }

    public string? MobNumb { get; set; }

    public long? PaydBpmainId { get; set; }

    public long? PaydLoctId { get; set; }

    public int? PayedChnl { get; set; }

    public string SttsTypeCode { get; set; } = null!;

    public bool? IsPayedOffline { get; set; }

    public DateTime? PayedOfflineDate { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int? CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
