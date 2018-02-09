using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckCafe
{
    abstract class Person
    {
        protected string Name { get; set; } //фио
        protected string Adres { get; set; } // адрес
        protected string Phone_Number { get; set; } //номер телефона
        

        protected Person(string name, string adres, string phone)
        {
            Name = name;
            Adres = adres;
            Phone_Number = phone;
        }

        #region // коррекция значений для класса
        public static string create_phone(string s)
        {
            return "phone "+s;
        }
        public static string create_name(string s)
        {
            return "name "+s;
        }
        public static string create_adres(string s)
        {
            return "adres "+s;
        }
        #endregion

    }
}
