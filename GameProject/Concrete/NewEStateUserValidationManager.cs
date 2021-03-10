using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class NewEStateUserValidationManager : IUserValidationService
    {

        //Yeni bir doğrulama sistemi gelirse 
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
