using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class KycAttr
{
    public int KycAttrId { get; set; }

    public string KycAttrName { get; set; } = null!;

    public string? KycAttrNameLocl { get; set; }

    public string? KycAttrDesc { get; set; }

    public string? DtypCode { get; set; }

    public int? MaxLong { get; set; }

    public string? KycAttrStts { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<AcctKycDetl> AcctKycDetls { get; set; } = new List<AcctKycDetl>();

    public virtual Dtyp? DtypCodeNavigation { get; set; }

    public virtual RqstSttsType? KycAttrSttsNavigation { get; set; }

    public virtual ICollection<KycSetDetl> KycSetDetls { get; set; } = new List<KycSetDetl>();

    public virtual ICollection<RemtTranKycDetl> RemtTranKycDetls { get; set; } = new List<RemtTranKycDetl>();
}
