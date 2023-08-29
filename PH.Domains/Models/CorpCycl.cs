using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpCycl
{
    public int CyclId { get; set; }

    public string CyclName { get; set; } = null!;

    public string? CyclNameLocal { get; set; }

    public string? CyclDesc { get; set; }

    public int CorpId { get; set; }

    public DateTime StrtDate { get; set; }

    public DateTime ExpDate { get; set; }

    public string CyclStts { get; set; } = null!;

    public decimal InsurBlokPerc { get; set; }

    public string CyclProcStts { get; set; } = null!;

    public decimal? Totamnt { get; set; }

    public int? Totremi { get; set; }

    public DateTime? LetterDate { get; set; }

    public DateTime? BatchDate { get; set; }

    public decimal? FeeAmnt { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? Lqdty { get; set; }

    public int? FeesGroupId { get; set; }

    public int? CmsnPrflId { get; set; }

    public bool? IsFeeDdctFrmBen { get; set; }

    public virtual Corp Corp { get; set; } = null!;

    public virtual ICollection<CorpCyclDetl> CorpCyclDetls { get; set; } = new List<CorpCyclDetl>();

    public virtual ICollection<CorpFileUpldDoc> CorpFileUpldDocs { get; set; } = new List<CorpFileUpldDoc>();

    public virtual ICollection<CorpRemtInssDetl> CorpRemtInssDetls { get; set; } = new List<CorpRemtInssDetl>();

    public virtual ICollection<CorpRemt> CorpRemts { get; set; } = new List<CorpRemt>();
}
