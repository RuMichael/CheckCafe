using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckCafe
{
    abstract class Person
    {
        public string Name { get; set; } //фио
        public string Adres { get; set; } // адрес
        public string Phone_Number { get; set; } //номер телефона
        

        public Person(string name, string adres, string phone)
        {
            Name = name;
            Adres = adres;
            Phone_Number = phone;
        }

        #region // коррекция значений для класса
        public static string create_phone()
        {
            return "phone";
        }
        public static string create_name()
        {
            return "name";
        }
        public static string create_adres()
        {
            return "adres";
        }
        #endregion

    }
}
