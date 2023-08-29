using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UpdateAcitivity
{
    public int WalletNo { get; set; }

    public string ActivtyName { get; set; } = null!;
}
