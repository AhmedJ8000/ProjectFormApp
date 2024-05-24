using System;
using System.Collections.Generic;

namespace HSMSBusinessObjects
{
    public partial class Document
    {
        public int DocumentId { get; set; }
        public string DocumentName { get; set; } = null!;
        public int UserId { get; set; }
        public DateTime UploadDate { get; set; }
        public string DocumentType { get; set; } = null!;
        public string DataPath { get; set; } = null!;

        public virtual User User { get; set; } = null!;
    }
}
