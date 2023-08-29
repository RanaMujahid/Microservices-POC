using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefMemberTemp
{
    public long MmbrId { get; set; }

    public string Membercode { get; set; } = null!;

    public string Uniquecode { get; set; } = null!;

    public string? Familymembernames { get; set; }

    public string? Membersfamilyname { get; set; }

    public string? Membersadjustedname { get; set; }

    public string? Gender { get; set; }

    public string? Flagdeceasednopayment { get; set; }

    public string? Flagpayonly { get; set; }

    public string? Flagdisqualified { get; set; }

    public string? Flagtakephoto { get; set; }

    public string? Flagverified { get; set; }

    public string? Flagrequirescmform { get; set; }

    public string? Nationalidnumber { get; set; }

    public string? Oldnationalidnumber { get; set; }

    public string? Electoralidnumber { get; set; }

    public string? Passportnumber { get; set; }

    public string? Familycardnumber { get; set; }

    public string? Birthcertificatenumber { get; set; }

    public string? Studentseatnumbercardnumber { get; set; }

    public string? Marriagecontractnumber { get; set; }

    public string? Disabledcareidnumber { get; set; }

    public string? Cviformnumber { get; set; }

    public string? Cmcode { get; set; }
}
