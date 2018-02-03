
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaWar
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 0;
            int y = 0;

            int[,] arrFieldUser = new int[10, 10];
            int[,] arrFieldComp = new int[10, 10];



            FieldAdd(arrFieldUser);
            FieldAdd(arrFieldComp);



            while (true)
            {
                FieldOnDisplayUser(arrFieldUser);
                Console.WriteLine();
                FieldOnDisplayComp(arrFieldComp, x, y);

                MooveOnDisplay(arrFieldComp, ref x, ref y);
                Console.Clear();
            }
        }
        /// <summary>
        /// метод заполнения массивов инфой(проверочный)
        /// </summary>
        /// <param name="arrField">массив для заполнения</param>
        /// 
        public static void FieldAdd(int[,] arrField)
        {
            for (int i = 0; i < arrField.GetLength(0); i++)
            {
                for (int j = 0; j < arrField.GetLength(1); j++)
                {
                    arrField[i, j] = 0;
                }
            }
        }

        /// <summary>
        /// Метод вывода на экран поля компьютера и курсора
        /// </summary>
        /// <param name="arrField">массив нашего поля </param>
        /// <param name="mooveOnX">расположение курсора по х </param>
        /// <param name="mooveOnY">расположение курсора по у</param>
        /// 
        public static void FieldOnDisplayComp(int[,] arrField, int mooveOnX, int mooveOnY)
        {
            for (int i = 0; i < arrField.GetLength(0); i++)
            {
                for (int j = 0; j < arrField.GetLength(1); j++)
                {
                    if (mooveOnX == i && mooveOnY == j)
                    {
                        Console.Write(5);
                    }
                    else
                    {
                        Console.Write(arrField[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }


        /// <summary>
        /// вывод на экран поля игрока
        /// </summary>
        /// <param name="arrField"> массив поля игрока</param>
        public static void FieldOnDisplayUser(int[,] arrField)
        {
            for (int i = 0; i < arrField.GetLength(0); i++)
            {
                for (int j = 0; j < arrField.GetLength(1); j++)
                {
                    Console.Write(arrField[i, j]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод движения по полю
        /// </summary>
        /// <param name="arrField"> массив поля</param>
        /// <param name="mooveOnX">переменная движения по вертикали</param>
        /// <param name="mooveOnY">переменная движения по горизонтали</param>
        public static void MooveOnDisplay(int[,] arrField, ref int mooveOnX, ref int mooveOnY)
        {
            ConsoleKeyInfo PressedKey = Console.ReadKey();


            switch (PressedKey.Key)
            {
                case ConsoleKey.RightArrow:
                    if (mooveOnY != arrField.GetLength(0) - 1)
                    {
                        mooveOnY++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (mooveOnY != 0)
                    {
                        mooveOnY--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (mooveOnX != arrField.GetLength(1) - 1)
                    {
                        mooveOnX++;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (mooveOnX != 0)
                    {
                        mooveOnX--;
                    }
                    break;
            }
        }


    }
}