using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UnicefMainBenfTmp
{
    public long MainMmbrId { get; set; }

    public string Uniquecode { get; set; } = null!;

    public string? Olduniquecode { get; set; }

    public string? Membercode { get; set; }

    public string? Primarybeneficiarynames { get; set; }

    public string? Baseamount { get; set; }

    public string? Topupamount { get; set; }

    public string? Primarybeneficiaryfamilyname { get; set; }

    public string? Gender { get; set; }

    public string? Governoratewherehelives { get; set; }

    public string? Districtwherehelives { get; set; }

    public string? Ozlawherehelives { get; set; }

    public string? Villagewherehelives { get; set; }

    public decimal? Amounttobepaid { get; set; }

    public string? Flagnopayment { get; set; }

    public string? Flagrequirescmform { get; set; }

    public string? Electronicpaymentflag { get; set; }

    public string? Flagoutreach { get; set; }

    public string? Cmcode { get; set; }

    public decimal? Totalpaymentamountyersouth { get; set; }

    public string? Paymentamountwithouttopupyersouth { get; set; }

    public string? Topupamountyersouth { get; set; }

    public decimal? Totalpaymentamountusdnorth { get; set; }

    public decimal? Totalpaymentamountusdsouth { get; set; }
}
