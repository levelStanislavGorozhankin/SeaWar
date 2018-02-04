using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaWarProject
{
    class BoatDeck
    {
        public bool HittingState; // статус палубы
        public int LocationX; // координата палубы
        public int LocationY; // координата палубы

        public BoatDeck(int locationX, int locationY)
        {
            LocationX = locationX;
            LocationY = locationY;
        }
    }
}
