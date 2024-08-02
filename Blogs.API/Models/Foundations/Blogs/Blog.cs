using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogs.API.Models.Foundations.Blogs
{
    public class Blog
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}