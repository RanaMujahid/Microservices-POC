using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class EPymt
{
    public int EPymtId { get; set; }

    public long EPymtNo { get; set; }

    public int? EPymtPrmtnId { get; set; }

    public string SuplRefNo { get; set; } = null!;

    public string? MrchntName { get; set; }

    public int CustSuplRgstnId { get; set; }

    public long CustBpMainId { get; set; }

    public int CustZoneId { get; set; }

    public string CustBrch { get; set; } = null!;

    public long SuplBpMainId { get; set; }

    public string SuplBrch { get; set; } = null!;

    public string DebtAcct { get; set; } = null!;

    public string CrdtAcct { get; set; } = null!;

    public decimal Amount { get; set; }

    public decimal Fee { get; set; }

    public string CrcyCode { get; set; } = null!;

    public decimal XchgRate { get; set; }

    public bool IsFeeDdctd { get; set; }

    public int TranTypeCode { get; set; }

    public int ChnlTypeCode { get; set; }

    public string TranStts { get; set; } = null!;

    public string? T24RefNo { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public DateTime? BsnsOprnDate { get; set; }

    public decimal? OrgnlFee { get; set; }
}
