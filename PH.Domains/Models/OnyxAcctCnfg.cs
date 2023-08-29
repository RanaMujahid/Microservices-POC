using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class OnyxAcctCnfg
{
    public int Id { get; set; }

    public int? TransTypeCode { get; set; }

    public int LdgrTranTypeCode { get; set; }

    public string? CrdtAcctNo { get; set; }

    public string? CrdtAcctName { get; set; }

    public string? CrdtAcctDesc { get; set; }

    public string? DebtAcctNo { get; set; }

    public string? DebtAcctName { get; set; }

    public string? DebtAcctDesc { get; set; }

    public string? AmntType { get; set; }

    public string? BpType { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    public long? SessionId { get; set; }

    public string? SessionCode { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Tran? TransTypeCodeNavigation { get; set; }
}
