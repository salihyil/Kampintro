using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using DenemeGameProject.Abstract;
using DenemeGameProject.Entities;

namespace DenemeGameProject.Concrete
{
    class GamerManager : IGamerService
    {
        IGamerValidationService _gamerValidationService; //_gamerValidationService initialization yapıyoruz.
        

        public GamerManager(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
            
        }

        public void GamerAdd(Gamer gamer)
        {
            if (_gamerValidationService.Validation(gamer)==true)
            {
                Console.WriteLine("{0} {1} kişisi doğrulandı." ,gamer.FirstName,gamer.LastName);
                Console.WriteLine("Kayıt eklendi.");
            }
            else
            {
                Console.WriteLine("Doğrulama olmadı ve kayıt gerçekleşmedi.");
            }
            
        }

        public void GamerDelete(Gamer gamer)
        { 
            Console.WriteLine("Delete olundu.");
        }

        public void GamerUpdate(Gamer gamer)
        {
            Console.WriteLine("Update olundu.");
        }
    }
}
