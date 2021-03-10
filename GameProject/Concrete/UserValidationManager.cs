using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;
using Microsoft.VisualBasic;

namespace GameProject.Concrete
{
    class UserValidationManager : IUserValidationService  //Abstractlar(soyut)  Concrete(somut)'lere eklenir.
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "Engin" && gamer.LastName == "Demiroğ" &&
                gamer.IdentityNumber == 12345)
            { //doğruysa true döndürmek isteğimiz için void Validate(Gamer gamer); bool Validate(Gamer gamer); olarak değiştik.
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
