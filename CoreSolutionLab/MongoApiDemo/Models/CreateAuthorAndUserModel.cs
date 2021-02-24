using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoApiDemo.Models
{
    public class CreateAuthorAndUserModel
    {
        public CreateAuthorModel AuthorModel { get; set; }

        public CreateUserModel UserModel { get; set; }
    }
}
