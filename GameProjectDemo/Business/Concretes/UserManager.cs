using Business.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserManager : IUserService 
    {
        private IUserValidationService _validationService;

        public UserManager(IUserValidationService validationService)
        {
            _validationService = validationService;
        }

        public void Add(User user)
        {
            if (_validationService.Validate(user) == true)
            {
                Console.WriteLine("Doğrulama başarılı kayıt oldu:  " + user.Name);
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız");
                Environment.Exit(0); // doğrulama başarısız ise uygulama kapanır 
            }
        }

       

        public void Delete(User user)
        {
            Console.WriteLine("Kullanıcı Silindi " + user.Name);

        }

        public void Update(User user)
        {
            Console.WriteLine("Kullanıcı Güncellendi " + user.Name);

        }
    }
}
