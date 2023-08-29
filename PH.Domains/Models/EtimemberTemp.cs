using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class EtimemberTemp
{
    public long RemtId { get; set; }

    public string? BenVerificationCode { get; set; }

    public string? BenElectronicId { get; set; }

    public string? BenName { get; set; }

    public string? PaymentAmount { get; set; }

    public string? GovernorateCode { get; set; }

    public string? DistrictCode { get; set; }

    public string? SchoolName { get; set; }

    public string? RequiresBankAccount { get; set; }

    public string? ScheduledPaymentDate { get; set; }

    public string? NoPaymentFlag { get; set; }

    public string? VerifiedFlag { get; set; }

    public string? RequiresVerificationFormFlag { get; set; }

    public string? EPaymentFlag { get; set; }

    public string? SubAccount { get; set; }
}
