using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace DenemeGameProject.Entities
{
    class Gamer
    {
        
        
        public int Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName  { get; set; }
        public int BirthYear { get; set; }
        public long IdentityId { get; set; }
    }
}
