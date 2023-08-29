using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class BpSysUser
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string? Pswd { get; set; }

    public string? BrchCode { get; set; }

    public long? Businesspartnerid { get; set; }

    public int AccsFailCount { get; set; }

    public bool IsFrstLogin { get; set; }

    public string LangCode { get; set; } = null!;

    public bool? LockOutEnab { get; set; }

    public DateTime? LockOutEnd { get; set; }

    public bool TwoFactEnab { get; set; }

    public string? UserStts { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Brch? BrchCodeNavigation { get; set; }

    public virtual BpMain? Businesspartner { get; set; }

    public virtual ICollection<ChldPrntDesgMap> ChldPrntDesgMapChlds { get; set; } = new List<ChldPrntDesgMap>();

    public virtual ICollection<ChldPrntDesgMap> ChldPrntDesgMapPrnts { get; set; } = new List<ChldPrntDesgMap>();

    public virtual ICollection<CorpRemt> CorpRemtCreatedByNavigations { get; set; } = new List<CorpRemt>();

    public virtual ICollection<CorpRemt> CorpRemtUpdatedByNavigations { get; set; } = new List<CorpRemt>();

    public virtual ICollection<CorpUserAgntReviewMap> CorpUserAgntReviewMaps { get; set; } = new List<CorpUserAgntReviewMap>();

    public virtual ICollection<EPymtWaltToBankBatch> EPymtWaltToBankBatches { get; set; } = new List<EPymtWaltToBankBatch>();

    public virtual ICollection<EtiRemtDocRevw> EtiRemtDocRevws { get; set; } = new List<EtiRemtDocRevw>();

    public virtual ICollection<RefundEPymtBatchDetl> RefundEPymtBatchDetls { get; set; } = new List<RefundEPymtBatchDetl>();

    public virtual ICollection<RefundEPymtBatch> RefundEPymtBatches { get; set; } = new List<RefundEPymtBatch>();

    public virtual ICollection<RfundEPymt> RfundEPymts { get; set; } = new List<RfundEPymt>();

    public virtual ICollection<UnicefRemtDocRevw> UnicefRemtDocRevws { get; set; } = new List<UnicefRemtDocRevw>();

    public virtual ICollection<UnicefUserAgntMap> UnicefUserAgntMaps { get; set; } = new List<UnicefUserAgntMap>();

    public virtual ICollection<UserDesgDetl> UserDesgDetls { get; set; } = new List<UserDesgDetl>();

    public virtual ICollection<UserRoleDetl> UserRoleDetls { get; set; } = new List<UserRoleDetl>();

    public virtual ICollection<WorkQue> WorkQueChkrs { get; set; } = new List<WorkQue>();

    public virtual ICollection<WorkQueHsty> WorkQueHsties { get; set; } = new List<WorkQueHsty>();

    public virtual ICollection<WorkQue> WorkQueMakrs { get; set; } = new List<WorkQue>();
}
