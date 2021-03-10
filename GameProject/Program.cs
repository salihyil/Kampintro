using System;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer()
            {
                FirstName = "Engin",
                LastName = "Demiroğ",
                BirthYear = 1985,
                IdentityNumber = 12345

            });

            //GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager()); 
            //gamerManager.Add(new Gamer()
            //{
            //    Id = 1,
            //    FirstName = "Salih"
            //});




        }
    }
}

