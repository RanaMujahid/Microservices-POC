using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefBenToPost
{
    public long UnicefBenToPostId { get; set; }

    public long? RemtId { get; set; }

    public long? OldAgntCode { get; set; }

    public string? SiteCode { get; set; }

    public string? Date { get; set; }

    public string? StrtTime { get; set; }

    public string? EndTime { get; set; }

    public string? UserName { get; set; }

    public string? FmlyCode { get; set; }

    public string? PrimryMmbrCode { get; set; }

    public string? BenIdType { get; set; }

    public string? BenIdNumb { get; set; }

    public string? Phon { get; set; }

    public bool? IsFail { get; set; }

    public int? Resn { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? ApiResp { get; set; }

    public string? ApiRqst { get; set; }

    public int? CyclId { get; set; }

    public string? OrgCode { get; set; }

    public string? Region { get; set; }

    public decimal? Amnt { get; set; }

    public virtual Cycl? Cycl { get; set; }
}
