using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Temp08052022
{
    public string UserName { get; set; } = null!;

    public string FrstName { get; set; } = null!;

    public string? MddlName { get; set; }

    public string LastName { get; set; } = null!;

    public string? FmlyName { get; set; }

    public int PhoneNumber { get; set; }

    public string Dob { get; set; } = null!;

    public string BranchName { get; set; } = null!;

    public byte BranchId { get; set; }

    public string Designation { get; set; } = null!;

    public byte UserRoleTypeCode { get; set; }

    public byte Code { get; set; }

    public string BrchAdrs { get; set; } = null!;
}
