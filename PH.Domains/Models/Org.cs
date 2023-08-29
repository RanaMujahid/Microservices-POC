using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Org
{
    public int OrgId { get; set; }

    public string? Code { get; set; }

    public string? OrgName { get; set; }

    public string? OrgNameLocal { get; set; }

    public string? OrgDesc { get; set; }

    public string? OrgSts { get; set; }

    public string? Mobile { get; set; }

    public string? OrgAddress { get; set; }

    public bool? RcvrPhon { get; set; }

    public bool? SendOtp { get; set; }

    public decimal? RemtFee { get; set; }

    public decimal? DpstFee { get; set; }

    public decimal? DpstYer { get; set; }

    public decimal? TrnsYer { get; set; }

    public decimal? DpstUsd { get; set; }

    public decimal? TrnsUsd { get; set; }

    public decimal? MinLmtYer { get; set; }

    public decimal? MinLmtUsd { get; set; }

    public string? Plac { get; set; }

    public string? OpenAcct { get; set; }

    public string? RpstvName { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? OrgWqStts { get; set; }

    public virtual ICollection<OrgDoc> OrgDocs { get; set; } = new List<OrgDoc>();

    public virtual OrgStt? OrgStsNavigation { get; set; }
}
