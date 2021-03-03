using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
        public class UserValidationManager : IUserValidationService
        {
            public bool CheckIfRealPerson(Gamer Gamer)
            {
                return true;
            }
        }
}
    
