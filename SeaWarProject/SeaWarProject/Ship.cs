using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaWarProject
{
    public class Ship
    {
        public int HeadShipX; //координата первой палубы корабля по Х
        public int HeadShipY; //координата первой палубы корабля по Y
        public bool State; // State = false, пока есть хоть одна живая палуба
        public BoatDeck[] Boat; // массив палуб
        public int ShipClass; //Класс корабля(количество клеток от 1 до 4)

        public Ship(int X, int Y, int shipClass, bool direction) // shipClass - количество палуб, direction true (расположение коробля по вертикали), false (по горизонтали)
        {
            HeadShipX = X;
            HeadShipY = Y;
            ShipClass = shipClass;

            Boat = new BoatDeck[shipClass];

            for (var i = 0; i < shipClass; i++)
            {
                Boat[i] = new BoatDeck(X, Y);
                if (direction)
                    X++;
                else Y++;
            }
        }
    }
}
