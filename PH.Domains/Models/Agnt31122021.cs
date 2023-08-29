using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Agnt31122021
{
    public int AgntId { get; set; }

    public long? OldAgntCode { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MddlName { get; set; }

    public string LastName { get; set; } = null!;

    public string? FmlyName { get; set; }

    public string? Addr { get; set; }

    public string? AgntNameLocal { get; set; }

    public string? AgntDesc { get; set; }

    public string BankAcctNo { get; set; } = null!;

    public string? WalletNo { get; set; }

    public string? PhneNo { get; set; }

    public string? Email { get; set; }

    public DateTime? Dob { get; set; }

    public string? AgntTypeCode { get; set; }

    public long BpMainId { get; set; }

    public int? SuprAgntId { get; set; }

    public string? StatusTypeCode { get; set; }

    public bool? IsKeAgent { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? FnanAcctNo { get; set; }

    public decimal? InssAmnt { get; set; }

    public bool? IsInssDdct { get; set; }

    public int? SubUserCount { get; set; }
}
