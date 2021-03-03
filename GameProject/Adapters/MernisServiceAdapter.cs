using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;
using GameProject.MernisServiceAdapter;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IUserValidationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(gamer.NationalityId, gamer.FirstName, gamer.LastName, gamer.BirthYear);
        }
    }
}
