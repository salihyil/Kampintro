using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    //MicroService yani ben bu GamerManager içinde başka//bir servis kullanıcam demek.(IUserValidationService kullanıcaz yani.)

    class GamerManager : IGamerService
    {
        //!!! Bir manager sınıfın içinde başka bir sınıfı kullancaksak asla o sınıfı newleme!!!! 

        IUserValidationService _userValidationService; //initialize field from constractor yapıyoruz.

        public GamerManager(IUserValidationService userValidationService)
        {//Bu constractorsdır metot gibi çalışır.

            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) != true)
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız.");
            }
            else
            {
                Console.WriteLine("Kayıt Olundu.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
