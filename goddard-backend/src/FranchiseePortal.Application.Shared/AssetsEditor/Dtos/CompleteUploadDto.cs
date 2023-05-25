using System;
using System.Collections.Generic;
using System.Text;

namespace FranchiseePortal.AssetsEditor.Dtos
{

    public class CompleteUploadDto : BaseUploadDto
    {
	public string Affinity { get; set; }
        public string CompleteUri { get; set; }
        public string UploadToken { get; set; }
        public string MimeType { get; set; }
    }
}
