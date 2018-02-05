using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaWarProject
{
    public class Players
    {
      // proba
        private string _name { get; set; }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (Name.Length > 2)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Введите имя подлинннее");
                }
            }
        }

        public Ship[] arrShip = new Ship[7];
    }
}
