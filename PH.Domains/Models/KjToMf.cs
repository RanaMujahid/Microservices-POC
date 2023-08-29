using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class KjToMf
{
    public long KjToMfId { get; set; }

    public decimal Amnt { get; set; }

    public decimal Fee { get; set; }

    public decimal Cmsn { get; set; }

    public string DebtAcct { get; set; } = null!;

    public string CrdtAcct { get; set; } = null!;

    public long SndrBpId { get; set; }

    public long RcvrBpId { get; set; }

    public string CustName { get; set; } = null!;

    public string? CustAcctType { get; set; }

    public string BankAcctNmbr { get; set; } = null!;

    public string CustBankLqdty { get; set; } = null!;

    public string ChrgdLqdty { get; set; } = null!;

    public string? Desc { get; set; }

    public DateTime TranDate { get; set; }

    public string TranTypeCode { get; set; } = null!;

    public string ChnlTypeCode { get; set; } = null!;

    public string ClntRoleTypeCode { get; set; } = null!;

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? BankAcctDao { get; set; }

    public decimal Lqdtyfee { get; set; }

    public DateTime? BsnsOprnDate { get; set; }
}
