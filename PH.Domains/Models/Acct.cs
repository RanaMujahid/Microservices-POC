using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Acct
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

    public virtual ICollection<AcctDetl> AcctDetls { get; set; } = new List<AcctDetl>();

    public virtual ICollection<AcctDoc> AcctDocs { get; set; } = new List<AcctDoc>();

    public virtual ICollection<AcctKycDetl> AcctKycDetls { get; set; } = new List<AcctKycDetl>();

    public virtual RqstSttsType AcctSttsNavigation { get; set; } = null!;

    public virtual ICollection<BillAdslPymt> BillAdslPymtCrdtAcctNavigations { get; set; } = new List<BillAdslPymt>();

    public virtual ICollection<BillAdslPymt> BillAdslPymtDebtAcctNavigations { get; set; } = new List<BillAdslPymt>();

    public virtual ICollection<BillElctPymt> BillElctPymtCrdtAcctNavigations { get; set; } = new List<BillElctPymt>();

    public virtual ICollection<BillElctPymt> BillElctPymtDebtAcctNavigations { get; set; } = new List<BillElctPymt>();

    public virtual ICollection<BillLandLinePymt> BillLandLinePymtCrdtAcctNavigations { get; set; } = new List<BillLandLinePymt>();

    public virtual ICollection<BillLandLinePymt> BillLandLinePymtDebtAcctNavigations { get; set; } = new List<BillLandLinePymt>();

    public virtual ICollection<BillMtnPkgPymt> BillMtnPkgPymtCrdtAcctNavigations { get; set; } = new List<BillMtnPkgPymt>();

    public virtual ICollection<BillMtnPkgPymt> BillMtnPkgPymtDebtAcctNavigations { get; set; } = new List<BillMtnPkgPymt>();

    public virtual ICollection<BillMtnPymt> BillMtnPymtCrdtAcctNavigations { get; set; } = new List<BillMtnPymt>();

    public virtual ICollection<BillMtnPymt> BillMtnPymtDebtAcctNavigations { get; set; } = new List<BillMtnPymt>();

    public virtual ICollection<BillWatrPymt> BillWatrPymtCrdtAcctNavigations { get; set; } = new List<BillWatrPymt>();

    public virtual ICollection<BillWatrPymt> BillWatrPymtDebtAcctNavigations { get; set; } = new List<BillWatrPymt>();

    public virtual ICollection<BillYgsmPymt> BillYgsmPymtCrdtAcctNavigations { get; set; } = new List<BillYgsmPymt>();

    public virtual ICollection<BillYgsmPymt> BillYgsmPymtDebtAcctNavigations { get; set; } = new List<BillYgsmPymt>();

    public virtual BpMain BpMain { get; set; } = null!;

    public virtual ICollection<FaildTran> FaildTrans { get; set; } = new List<FaildTran>();

    public virtual ICollection<FrzAcct> FrzAccts { get; set; } = new List<FrzAcct>();

    public virtual ICollection<OrgRemt> OrgRemtCrdtAcctNavigations { get; set; } = new List<OrgRemt>();

    public virtual ICollection<OrgRemt> OrgRemtDebtAcctNavigations { get; set; } = new List<OrgRemt>();

    public virtual Prod Prod { get; set; } = null!;

    public virtual ICollection<SuprAgnt> SuprAgnts { get; set; } = new List<SuprAgnt>();

    public virtual ClntRoleType TypeNavigation { get; set; } = null!;
}
