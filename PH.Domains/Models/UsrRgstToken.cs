using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UsrRgstToken
{
    public long UsrRgstTokenId { get; set; }

    public long BpMainId { get; set; }

    public string Appcode { get; set; } = null!;

    public string Token { get; set; } = null!;

    public DateTime RegisterOn { get; set; }
}
