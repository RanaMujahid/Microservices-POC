using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class PhCorpLoginDashBoard
{
    public int LoginId { get; set; }

    public string UserName { get; set; } = null!;

    public string? Email { get; set; }

    public string Password { get; set; } = null!;

    public int? RoleId { get; set; }

    public int? CorpId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public bool? Active { get; set; }

    public bool CashTranRprt { get; set; }

    public bool ViewDwndAtch { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? FromTime { get; set; }

    public string? ToTime { get; set; }
}
