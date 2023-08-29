using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class SuprAgnt
{
    public int SuprAgntId { get; set; }

    public string SuprAgntCode { get; set; } = null!;

    public string? FrstName { get; set; }

    public string? MddlName { get; set; }

    public string? LastName { get; set; }

    public string? FmlyName { get; set; }

    public string? AgntNameLocal { get; set; }

    public string? Addr { get; set; }

    public string? Desc { get; set; }

    public string? PhonNumb { get; set; }

    public string? Email { get; set; }

    public DateTime? Dob { get; set; }

    public string? AgntTypeCode { get; set; }

    public int? SubAgntCount { get; set; }

    public int? SubUserCount { get; set; }

    public string? TranLevlCode { get; set; }

    public string? CmplSettngCode { get; set; }

    public string WalletNo { get; set; } = null!;

    public string? BankAcctNo { get; set; }

    public long BpMainId { get; set; }

    public string? InssAcct { get; set; }

    public decimal InssAmnt { get; set; }

    public decimal? InitialInssBlnc { get; set; }

    public bool IsInssDdct { get; set; }

    public string? FnanAcctNo { get; set; }

    public string SttsTypeCode { get; set; } = null!;

    public bool IsKeagent { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? AgntState { get; set; }

    public virtual BpMain BpMain { get; set; } = null!;

    public virtual ICollection<SuprAgntCmsnPrfl> SuprAgntCmsnPrfls { get; set; } = new List<SuprAgntCmsnPrfl>();

    public virtual ICollection<SuprAgntDoc> SuprAgntDocs { get; set; } = new List<SuprAgntDoc>();

    public virtual Acct WalletNoNavigation { get; set; } = null!;
}
