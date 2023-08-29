using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class OrgRemt
{
    public long RemtId { get; set; }

    public string RemtExprsNo { get; set; } = null!;

    public string RemtCardNo { get; set; } = null!;

    public string DebtAcct { get; set; } = null!;

    public string CrdtAcct { get; set; } = null!;

    public string SttsCode { get; set; } = null!;

    public string SndrOrgName { get; set; } = null!;

    public string? SndrOrgCode { get; set; }

    public decimal Amnt { get; set; }

    public decimal Fee { get; set; }

    public decimal Cmsn { get; set; }

    public string? Desc { get; set; }

    public string BenfName { get; set; } = null!;

    public string? BenfPhon { get; set; }

    public long MainPrfmrId { get; set; }

    public long? SubPrfmrId { get; set; }

    public string PrfmrType { get; set; } = null!;

    public DateTime TranDate { get; set; }

    public int TranTypeCode { get; set; }

    public int ChnlTypeCode { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Acct CrdtAcctNavigation { get; set; } = null!;

    public virtual Acct DebtAcctNavigation { get; set; } = null!;

    public virtual BpMain MainPrfmr { get; set; } = null!;

    public virtual BpMain? SubPrfmr { get; set; }
}
