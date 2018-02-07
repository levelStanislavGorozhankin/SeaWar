using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaWarProject
{
    class ComputerPlayer : Players
    {
        private List<int>[] LastMoves = new List<int>[2];

        public ComputerPlayer()
        {
            InitShips();

            for (var i = 0; i < 2; i++)
            {
                LastMoves[i] = new List<int>();
            }
        }

        public override void DoMove(int[,] field, Ship[] enemyShipsArray)
        {
            int x, y;
            x = Rand.Next(0, Program.XY);
            y = Rand.Next(0, Program.XY);

            WriteLastShot(ref x, ref y);

            if (HitTest(x, y, enemyShipsArray))
            {
                field[x, y] = 3;
            }
            else
                field[x, y] = 2;
        }

        /// <summary>
        /// Запись последнего выстрела в массив 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void WriteLastShot(ref int x, ref int y)
        {
            if (LastMoves[0].Count == 0)
            {
                LastMoves[0].Add(x);
                LastMoves[1].Add(y);
            }
            else
            {
                while (RepeatTestShot(x, y))
                {
                    x = Rand.Next(0, Program.XY);
                    y = Rand.Next(0, Program.XY);
                }
                LastMoves[0].Add(x);
                LastMoves[1].Add(y);
            }
        }

        /// <summary>
        /// Проверка выстрела компьютера на повтор
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool RepeatTestShot(int x, int y)
        {
            for (var i = 0; i < LastMoves[0].Count; i++)
            {
                if (LastMoves[0][i] == x && LastMoves[1][i] == y)
                    return true;
            }
            return false;
        }
    }
}
