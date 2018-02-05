using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaWarProject
{
    public class Players
    {
        public Ship[] ShipsArray = new Ship[10];
        private string _name { get; set; }
        static private Random Rand = new Random();

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (value.Length > 2)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Введите имя подлинннее");
                }
            }
        }

        public void InitShips()
        {
            bool directition = Rand.Next(2) == 0 ? false : true;
            int shipClass = 4;
            Ship tmpShip = new Ship(Rand.Next(0, directition ? Program.XY - shipClass : Program.XY), Rand.Next(0, directition ? Program.XY : Program.XY - shipClass), shipClass, directition);
            for (int count = 0; count < ShipsArray.Length; count++)
            {
                ShipsArray[count] = tmpShip;
                if (count == 0 || count == 2 || count == 5)
                    shipClass--;
                directition = Rand.Next(2) == 0 ? false : true;
                while (TestShipLocation(tmpShip))
                {
                    tmpShip = new Ship(Rand.Next(0, directition ? Program.XY - shipClass : Program.XY), Rand.Next(0, directition ? Program.XY : Program.XY - shipClass), shipClass, directition);
                }
            }

        }

        /// <summary>
        /// Хуй тут опишешь логику в коментах
        /// </summary>
        /// <param name="tmpShip"></param>
        /// <returns></returns>
        private bool TestShipLocation(Ship tmpShip)
        {
            for (var count = 0; count < ShipsArray.Length; count++)
            {
                if (ShipsArray[count] != null)
                {
                    for (var numberDeck = 0; numberDeck < ShipsArray[count].ShipClass; numberDeck++)
                    {
                        for (var numberDeckTmpShip = 0; numberDeckTmpShip < tmpShip.ShipClass; numberDeckTmpShip++)
                        {
                            for (var x = ShipsArray[count].Boat[numberDeck].LocationX - 1; x < ShipsArray[count].Boat[numberDeck].LocationX + 2; x++)
                            {
                                for (var y = ShipsArray[count].Boat[numberDeck].LocationY - 1; y < ShipsArray[count].Boat[numberDeck].LocationY + 2; y++)
                                {
                                    if (x == tmpShip.Boat[numberDeckTmpShip].LocationX
                                        && y == tmpShip.Boat[numberDeckTmpShip].LocationY)
                                        return true;
                                }
                            }
                        }
                    }
                }
                else return false;
            }
            return false;
        }
    }
}
