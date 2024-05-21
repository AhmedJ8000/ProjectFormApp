using System;
using System.Collections.Generic;

namespace HSMSBusinessObjects
{
    public partial class Document
    {
        public int DocumentId { get; set; }
        public string DocumentName { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public DateTime UploadDate { get; set; }
        public string DocumentType { get; set; } = null!;
        public string DataPath { get; set; } = null!;

        public virtual AspNetUser User { get; set; } = null!;
    }
}
