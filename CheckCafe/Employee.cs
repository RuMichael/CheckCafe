using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckCafe
{
    class Employee : Person
    {
        static int Id_counter;  // счетчик работников      
        public string Position; // должность
        public int Id_number { get; set; } // номер работника

        public Employee(string name, string adres, string phone, string position) : base(name, adres, phone)
        {
            if (Id_counter == 0)
                Id_counter = 1;
            else
                Id_counter++;
            Id_number = Id_counter;
            Position = position;
            
        }        

    }
}
