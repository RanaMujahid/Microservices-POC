using System;
using System.Collections.Generic;

namespace PH.Domains.Models;

public partial class UpldDocDetl
{
    public long DocId { get; set; }

    public string DocName { get; set; } = null!;

    public string DocType { get; set; } = null!;

    public string DocPath { get; set; } = null!;

    public string DocExt { get; set; } = null!;

    public string DocMdul { get; set; } = null!;

    public DateTime DocUpldDate { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public long SessionId { get; set; }

    public string SessionCode { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public byte[]? DocContent { get; set; }

    public virtual ICollection<AcctDoc> AcctDocs { get; set; } = new List<AcctDoc>();

    public virtual ICollection<AgntLoctDoc> AgntLoctDocs { get; set; } = new List<AgntLoctDoc>();

    public virtual ICollection<BenProfDoc> BenProfDocs { get; set; } = new List<BenProfDoc>();

    public virtual ICollection<CorpDoc> CorpDocs { get; set; } = new List<CorpDoc>();

    public virtual ICollection<CorpFileUpldDoc> CorpFileUpldDocs { get; set; } = new List<CorpFileUpldDoc>();

    public virtual ICollection<CorpLoct> CorpLocts { get; set; } = new List<CorpLoct>();

    public virtual ICollection<Corp> Corps { get; set; } = new List<Corp>();

    public virtual ICollection<DpstFileUpldDoc> DpstFileUpldDocs { get; set; } = new List<DpstFileUpldDoc>();

    public virtual ICollection<EPymtWaltToBankBatch> EPymtWaltToBankBatches { get; set; } = new List<EPymtWaltToBankBatch>();

    public virtual FrzAcctDoc? FrzAcctDoc { get; set; }

    public virtual ICollection<RefundEPymtBatch> RefundEPymtBatches { get; set; } = new List<RefundEPymtBatch>();

    public virtual ICollection<UnicefRemtDoc> UnicefRemtDocs { get; set; } = new List<UnicefRemtDoc>();
}
