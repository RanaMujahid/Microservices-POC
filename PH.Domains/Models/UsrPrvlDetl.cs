using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UsrPrvlDetl
{
    public int UsrPrvlDetlId { get; set; }

    public int UsrId { get; set; }

    public int MenuPrvlId { get; set; }

    public virtual MenuPrvl MenuPrvl { get; set; } = null!;
}
