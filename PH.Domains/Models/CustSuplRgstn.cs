using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CustSuplRgstn
{
    public long CustSuplRgstnId { get; set; }

    public long SuplBpMainId { get; set; }

    public long CustBpMainId { get; set; }

    public string CustAcctNmber { get; set; } = null!;

    public string? MumiazNmber { get; set; }

    public string? BankAcctBrch { get; set; }

    public string? BankCustName { get; set; }

    public string? CustExtlId { get; set; }

    public string? CustMobileNo { get; set; }

    public string? CustEmail { get; set; }

    public int ChnlTypeCode { get; set; }

    public string SCustId { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
