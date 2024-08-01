using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratikConstructor
{
    public class Bebek
    {
        public string _name;
        public string _surname;
        public DateTime _Birthday;
        public Bebek()
        {
            _name = "Emre";
            _surname = "Terkan";
            _Birthday = DateTime.Now;
            Console.WriteLine("Ingaaaa" + " " + _Birthday);

        }

        public Bebek(string name, string surname) 
        { 
            _name = name;
            _surname = surname;
            _Birthday= DateTime.Now;
            Console.WriteLine("Bebeğin adı: " + _name + " " + _surname, _Birthday);
        }

       
    }
}
