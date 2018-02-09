using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckCafe
{
    class client : Person
    {
        string Number_card; // номер карты
        
        public client(string name, string adres, string phone_number, string card ) : base (name,  adres,  phone_number)
        {
            Number_card = card;
        }

    }
}
