using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoApiDemo.Models
{
    public class CreateAuthorModel
    {
        public string Name { get; set; }

        public IEnumerable<BookModel> Books { get; set; }
    }
}
