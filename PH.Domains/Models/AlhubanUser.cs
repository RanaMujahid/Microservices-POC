using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class AlhubanUser
{
    public string UserName { get; set; } = null!;

    public string EmployeeName { get; set; } = null!;

    public string Role { get; set; } = null!;

    public string Branch { get; set; } = null!;
}
