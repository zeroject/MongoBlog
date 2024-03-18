using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Post
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int BlogID { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Content { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public List<Comment>? comments { get; set; } = null;
    }
}
