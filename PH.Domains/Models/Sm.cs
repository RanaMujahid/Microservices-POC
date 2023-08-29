using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Sm
{
    public long SmsId { get; set; }

    public int? UserId { get; set; }

    public string? UserName { get; set; }

    public bool? IsPosted { get; set; }

    public string? SmsBody { get; set; }

    public DateTime? SmsSentDate { get; set; }

    public string? SmsType { get; set; }

    public long? TranId { get; set; }

    public int? SmsOtpNum { get; set; }

    public string? SmsTrgtPhnNum { get; set; }

    public bool? SmsIsVerified { get; set; }
}
