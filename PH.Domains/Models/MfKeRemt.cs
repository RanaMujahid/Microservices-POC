using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class MfKeRemt
{
    public long MfKeRemtId { get; set; }

    public string? KeNo { get; set; }

    public string? KeRemtTypeCode { get; set; }

    public long? KeRemtId { get; set; }

    public string? RemtRefNo { get; set; }

    public string DebtAcct { get; set; } = null!;

    public string CrdtAcct { get; set; } = null!;

    public string RemtSttsCode { get; set; } = null!;

    public string? RemtTypeCode { get; set; }

    public string? SndrName { get; set; }

    public string? SndrPhon { get; set; }

    public string? RcvrName { get; set; }

    public string? RcvrPhon { get; set; }

    public decimal Amnt { get; set; }

    public decimal Fee { get; set; }

    public decimal Cmsn { get; set; }

    public string? Notes { get; set; }

    public long MainPrfmrId { get; set; }

    public long? SubPrfmrId { get; set; }

    public string PrfmrType { get; set; } = null!;

    public string? IdType { get; set; }

    public string? IdNmbr { get; set; }

    public DateTime? SendDate { get; set; }

    public DateTime TranDate { get; set; }

    public int TranTypeCode { get; set; }

    public string? PrfmrBrch { get; set; }

    public string? PrfmrLqdty { get; set; }

    public int ChnlTypeCode { get; set; }

    public string? SendLqdtyCode { get; set; }

    public string? RecevLqdtyCode { get; set; }

    public string? PayLqdty { get; set; }

    public decimal? PayLqdtyFee { get; set; }

    public decimal? XchgRate { get; set; }

    public string? CurrId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public DateTime? BsnsOprnDate { get; set; }

    public string? SndrBrch { get; set; }
}
