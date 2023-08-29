using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AcctBeforeVip
{
    public long AcctId { get; set; }

    public long BpMainId { get; set; }

    public int ProdId { get; set; }

    public string AcctStts { get; set; } = null!;

    public string WaltAcctNmbr { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? BankAcctNmbr { get; set; }

    public decimal AvblBlnc { get; set; }

    public decimal UsblBlnc { get; set; }

    public string LevlId { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? CurrId { get; set; }

    public string? SubType { get; set; }

    public string? BsnsTypeId { get; set; }

    public string? FinancialAcctNmbr { get; set; }

    public string? OldAcctNmbr { get; set; }

    public string? InsuranceAcctNmbr { get; set; }

    public decimal? InsuranceInitialBalance { get; set; }

    public decimal? ReservePercentageOfInsuranceAccount { get; set; }
}
