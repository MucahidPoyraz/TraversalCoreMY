using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCoreMY.Entity.Concrete.Blog
{
    public class Comment : BaseEntity
    {
        public string WriterName { get; set; }
        public DateTime CommentDate { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; }
        public int DestinationId { get; set; }
        public Destination Destination { get; set; }
    }
}