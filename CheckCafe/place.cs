using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckCafe
{
    class place
    {
        //место
        private int count = 0;
        private List<client> cl = new List<client>();
        public List<DateTime> in_data;   //пришел
        public List<DateTime> out_data;  //ушел


        public place ()
        {   
            cl.Add(place.Pusto);
            //in_data = DateTime.Now(;
        }

        public void Add(string val) // добавляем клиента, это может быть пусто или клиент или пользователь
        {

        }


        public static client Pusto = new client("Пусто", "", "", "");
        public static client User = new client("Пользователь", "", "", "");
    }
}
