using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class OldUserLoginDetl
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Pswd { get; set; } = null!;

    public string? Salt { get; set; }

    public string? Hash { get; set; }

    public bool? IsFrstPswdResetd { get; set; }
}
