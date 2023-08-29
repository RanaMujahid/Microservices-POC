using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class Unicefdataupload
{
    public string? Name { get; set; }

    public string? SiteCode { get; set; }

    public string? PaymentAgencyId { get; set; }

    public string? OzlaCode { get; set; }

    public DateTime? InitialDate { get; set; }

    public DateTime? EndingDate { get; set; }

    public int? ExpectedNoOfBeneficiaries { get; set; }

    public decimal? GpsLatitude { get; set; }

    public decimal? GpsLongitude { get; set; }

    public string? Type { get; set; }

    public string? ConnectionType { get; set; }

    public string? FixedSiteType { get; set; }

    public int? WorkingDays { get; set; }

    public int? NumberDailyPayments { get; set; }

    public int? StaffingMalesCashiers { get; set; }

    public int? StaffingFemalesCashiers { get; set; }

    public int? StaffingMalesScreening { get; set; }

    public string? MobilePhoneNumber { get; set; }

    public string? StatusResponse { get; set; }

    public string? RequestJson { get; set; }

    public string? Reason { get; set; }

    public bool? Success { get; set; }

    public long Sno { get; set; }

    public string? PaymentSiteAddress { get; set; }

    public string? PaymentAgent { get; set; }

    public string? StaffingFemalesScreening { get; set; }

    public string? SiteStatus { get; set; }

    public bool? IsProductionEnvironment { get; set; }

    public string? ProjectName { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? RegionPaymentSite { get; set; }
}
