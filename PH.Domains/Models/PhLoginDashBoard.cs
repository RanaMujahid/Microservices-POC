using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class PhLoginDashBoard
{
    public int LoginId { get; set; }

    public string UserName { get; set; } = null!;

    public string? Email { get; set; }

    public string Password { get; set; } = null!;

    public int? RoleId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public bool? Active { get; set; }
}
