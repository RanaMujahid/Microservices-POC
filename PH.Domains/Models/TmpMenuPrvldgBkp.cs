using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class TmpMenuPrvldgBkp
{
    public string MenuPrvlName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public int UsrPrvlDetlId { get; set; }

    public int UsrId { get; set; }

    public int MenuPrvlId { get; set; }
}
