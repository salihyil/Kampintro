using System;
using System.Collections.Generic;
using System.Text;
using DenemeGameProject.Abstract;
using DenemeGameProject.Entities;

namespace DenemeGameProject.Concrete
{
    class GamerValidationManager : IGamerValidationService
    {
        public bool Validation(Gamer gamer) //Doğrulama işlemi
        {
            if (gamer.Id==1 && gamer.FirstName=="salih" && gamer.LastName=="yılmaz")
            {
                return true;

            }
            else
            {
                
                return false;
            }
        }
    }
}
