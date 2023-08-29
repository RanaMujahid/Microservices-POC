using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class BlckListStpdOprn
{
    public long BlckListStpdOprnId { get; set; }

    public string? PrfmrAcct { get; set; }

    public string? PrfmrName { get; set; }

    public string? RcvrAcct { get; set; }

    public string? RcvrName { get; set; }

    public DateTime TranDate { get; set; }

    public string? PrfmrCurrId { get; set; }

    public decimal? Amnt { get; set; }

    public string? TranTypeCode { get; set; }

    public string? ChnlTypeCode { get; set; }

    public string? PrfmrBsnsTypeId { get; set; }

    public string? PrfmrBrchCode { get; set; }

    public string? RcvrBrchCode { get; set; }

    public string? PrfmrBankAcctNmbr { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? Dob { get; set; }

    public string? Pob { get; set; }

    public string? Phn { get; set; }

    public string? Ntlty { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public DateTime? BsnsOprnDate { get; set; }
}
