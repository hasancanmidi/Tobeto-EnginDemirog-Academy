using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public  interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
