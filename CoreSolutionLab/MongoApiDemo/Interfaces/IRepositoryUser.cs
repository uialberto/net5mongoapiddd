using MongoApiDemo.Entities;
using MongoApiDemo.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoApiDemo.Interfaces
{
    public interface IRepositoryUser : IRepositoryBase<User>
    {
        Task<IEnumerable<User>> GetUsersAsync();

        Task<User> GetUserAsync(string id);
    }
}
