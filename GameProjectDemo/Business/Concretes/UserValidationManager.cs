using Business.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.BirthYear <= 2005  && user.IdentityNo.Length == 11 )
            {
                return true;
            }

            else return false;
        }
    }
}
