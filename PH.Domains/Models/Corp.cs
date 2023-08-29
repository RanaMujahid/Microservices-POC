using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Corp
{
    public int CorpId { get; set; }

    public string? CorpCode { get; set; }

    public string CorpName { get; set; } = null!;

    public string? CorpNameLocal { get; set; }

    public string CorpStts { get; set; } = null!;

    public string? CorpDesc { get; set; }

    public int? MoblNmbr { get; set; }

    public string? CorpAddress { get; set; }

    public bool? RcvrPhon { get; set; }

    public bool? SendOtp { get; set; }

    public string AcctNmbr { get; set; } = null!;

    public long DocId { get; set; }

    public string? RpstvName { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<CorpCycl> CorpCycls { get; set; } = new List<CorpCycl>();

    public virtual ICollection<CorpFileUpldDoc> CorpFileUpldDocs { get; set; } = new List<CorpFileUpldDoc>();

    public virtual ICollection<CorpLoctActv> CorpLoctActvs { get; set; } = new List<CorpLoctActv>();

    public virtual ICollection<CorpRemtInssDetl> CorpRemtInssDetls { get; set; } = new List<CorpRemtInssDetl>();

    public virtual ICollection<CorpRemt> CorpRemts { get; set; } = new List<CorpRemt>();

    public virtual OrgStt CorpSttsNavigation { get; set; } = null!;

    public virtual UpldDocDetl Doc { get; set; } = null!;
}
