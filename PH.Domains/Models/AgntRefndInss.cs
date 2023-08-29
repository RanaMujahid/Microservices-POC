using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AgntRefndInss
{
    public int AgntRefndInssId { get; set; }

    public int AgntId { get; set; }

    public long BpMainId { get; set; }

    public long AgntCnclReqId { get; set; }

    public string BankAcctNmbr { get; set; } = null!;

    public decimal InssAmnt { get; set; }

    public bool IsInssDdct { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? BankAcctDao { get; set; }

    public string? BankCustName { get; set; }

    public virtual AgntCnclReq AgntCnclReq { get; set; } = null!;
}
