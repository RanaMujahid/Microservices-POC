using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class CorpRemtTemp
{
    public long RemtId { get; set; }

    public string? FinaNumb { get; set; }

    public string? CardNumb { get; set; }

    public string? ReciName { get; set; }

    public string? SendName { get; set; }

    public string? Amnt { get; set; }

    public string? Comment { get; set; }

    public string? MobNumb { get; set; }

    public int CyclId { get; set; }

    public int CorpId { get; set; }

    public string? SerlNo { get; set; }

    public string? IdType { get; set; }

    public string? PrjtNme { get; set; }

    public string? Ref { get; set; }

    public string? Addr { get; set; }

    public string? TrsfrCndtn { get; set; }

    public string? AltName { get; set; }

    public string? AltIdType { get; set; }

    public string? AltIdNum { get; set; }

    public string? SmsMsg { get; set; }

    public string? ExtraClmn1 { get; set; }

    public string? ExtraClmn2 { get; set; }
}
