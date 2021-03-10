using System;
using System.Collections.Generic;
using System.Text;
using DenemeGameProject.Entities;

namespace DenemeGameProject.Abstract
{
    interface IGamerService
    {
        void GamerAdd(Gamer gamer);
        void GamerUpdate(Gamer gamer);
        void GamerDelete(Gamer gamer);
    }
}
