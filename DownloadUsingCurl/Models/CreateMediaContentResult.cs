using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadUsingCurl.Models
{
    public class CreateMediaContentResult
    {
        public Guid Id { get; set; }
        public string PresignedUploadUrl { get; set; }
        public string MultiUploadId { get; set; }
    }
}
