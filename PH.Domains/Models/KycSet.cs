using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class KycSet
{
    public int KycSetId { get; set; }

    public string KycSetName { get; set; } = null!;

    public string? KycSetNameLocl { get; set; }

    public string? KycSetDesc { get; set; }

    public string? ClntRoleTypeCode { get; set; }

    public string? KycSetStts { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<AcctKycDetl> AcctKycDetls { get; set; } = new List<AcctKycDetl>();

    public virtual ClntRoleType? ClntRoleTypeCodeNavigation { get; set; }

    public virtual ICollection<CustProfSetg> CustProfSetgs { get; set; } = new List<CustProfSetg>();

    public virtual ICollection<KycSetDetl> KycSetDetls { get; set; } = new List<KycSetDetl>();

    public virtual RqstSttsType? KycSetSttsNavigation { get; set; }

    public virtual ICollection<Prod> Prods { get; set; } = new List<Prod>();

    public virtual ICollection<RemtTranKycDetl> RemtTranKycDetls { get; set; } = new List<RemtTranKycDetl>();
}
