using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Comment
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public required string Content { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
