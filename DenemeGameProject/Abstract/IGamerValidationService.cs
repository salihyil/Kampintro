using System;
using System.Collections.Generic;
using System.Text;
using DenemeGameProject.Entities;

namespace DenemeGameProject.Abstract
{
    interface IGamerValidationService
    {
        bool Validation(Gamer gamer);
    }
}
