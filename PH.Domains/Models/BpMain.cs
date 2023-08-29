using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class BpMain
{
    public long BpMainId { get; set; }

    public long? BpSecdId { get; set; }

    public string? BrchCode { get; set; }

    public string BpType { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<Acct> Accts { get; set; } = new List<Acct>();

    public virtual Agnt? Agnt { get; set; }

    public virtual ICollection<BillAdslPymt> BillAdslPymts { get; set; } = new List<BillAdslPymt>();

    public virtual ICollection<BillElctPymt> BillElctPymts { get; set; } = new List<BillElctPymt>();

    public virtual ICollection<BillLandLinePymt> BillLandLinePymts { get; set; } = new List<BillLandLinePymt>();

    public virtual ICollection<BillMtnPymt> BillMtnPymts { get; set; } = new List<BillMtnPymt>();

    public virtual ICollection<BillWatrPymt> BillWatrPymts { get; set; } = new List<BillWatrPymt>();

    public virtual ICollection<BillYgsmPymt> BillYgsmPymts { get; set; } = new List<BillYgsmPymt>();

    public virtual ICollection<BpDetl> BpDetls { get; set; } = new List<BpDetl>();

    public virtual ICollection<BpSysUser> BpSysUsers { get; set; } = new List<BpSysUser>();

    public virtual ClntRoleType BpTypeNavigation { get; set; } = null!;

    public virtual Brch? BrchCodeNavigation { get; set; }

    public virtual ICollection<CashWdrlDetl> CashWdrlDetls { get; set; } = new List<CashWdrlDetl>();

    public virtual ICollection<CashWdrl> CashWdrls { get; set; } = new List<CashWdrl>();

    public virtual ICollection<CorpLoctActv> CorpLoctActvs { get; set; } = new List<CorpLoctActv>();

    public virtual ICollection<CorpLoct> CorpLocts { get; set; } = new List<CorpLoct>();

    public virtual ICollection<CorpRemtDetl> CorpRemtDetls { get; set; } = new List<CorpRemtDetl>();

    public virtual ICollection<CorpRemtInssDetl> CorpRemtInssDetls { get; set; } = new List<CorpRemtInssDetl>();

    public virtual ICollection<CorpRemt> CorpRemts { get; set; } = new List<CorpRemt>();

    public virtual ICollection<CorpUserAgntReviewMap> CorpUserAgntReviewMaps { get; set; } = new List<CorpUserAgntReviewMap>();

    public virtual ICollection<FaildTran> FaildTrans { get; set; } = new List<FaildTran>();

    public virtual ICollection<OfflnUser> OfflnUsers { get; set; } = new List<OfflnUser>();

    public virtual ICollection<OrgRemt> OrgRemtMainPrfmrs { get; set; } = new List<OrgRemt>();

    public virtual ICollection<OrgRemt> OrgRemtSubPrfmrs { get; set; } = new List<OrgRemt>();

    public virtual ICollection<QrAgntDetl> QrAgntDetls { get; set; } = new List<QrAgntDetl>();

    public virtual ICollection<QrCashrDetl> QrCashrDetls { get; set; } = new List<QrCashrDetl>();

    public virtual ICollection<SuprAgntAlwdCrcy> SuprAgntAlwdCrcies { get; set; } = new List<SuprAgntAlwdCrcy>();

    public virtual ICollection<SuprAgnt> SuprAgnts { get; set; } = new List<SuprAgnt>();

    public virtual ICollection<UserChngngBrchRqst> UserChngngBrchRqsts { get; set; } = new List<UserChngngBrchRqst>();
}
