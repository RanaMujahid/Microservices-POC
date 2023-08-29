using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class T24CobDate
{
    public long T24CobDateId { get; set; }

    public DateTime T24Date { get; set; }

    public DateTime CreatedOn { get; set; }

    public long CreatedBy { get; set; }
}
