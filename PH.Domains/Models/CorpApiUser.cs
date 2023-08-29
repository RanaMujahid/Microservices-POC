using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpApiUser
{
    public string UserName { get; set; } = null!;

    public string Pswd { get; set; } = null!;

    public int CorpId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }
}
