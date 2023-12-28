using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortF.Core.Domain
{
    public class BlogModel : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string  ImgUrl { get; set; }
    }
}
