using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UserDvceRgstDetl
{
    public long UserDvceRgstDetlId { get; set; }

    public string UserName { get; set; } = null!;

    public string DvceId { get; set; } = null!;

    public string MacAddrs { get; set; } = null!;

    public DateTime RegisterOn { get; set; }
}
