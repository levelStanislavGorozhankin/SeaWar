﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaWar
{
    class Program
    {
        const int XY = 10;
        static void Main(string[] args)
        {

            int x = 0;
            int y = 0;

            int[,] arrFieldUser = new int[XY, XY];
            int[,] arrFieldComp = new int[XY, XY];

            Console.CursorVisible = false;

            FieldAdd(arrFieldUser);
            FieldAdd(arrFieldComp);

            

            while (true)
            {
                FieldOnDisplayUser(arrFieldUser);
                Console.WriteLine();
                FieldOnDisplayComp(arrFieldComp, x, y);

                MooveOnDisplay(arrFieldComp, ref x, ref y);
                Console.SetCursorPosition(0, 0);
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
        public static void FieldOnDisplayComp(int[,] arrField, int moveOnX, int moveOnY)
        {
            Console.Write("┌");
            for (var i = 0; i < XY * 2; i++)
            {
                Console.Write("─");
            }
            Console.WriteLine("┐");

            for (int i = 0; i < arrField.GetLength(0); i++)
            {
                Console.Write("│");
                for (int j = 0; j < arrField.GetLength(1); j++)
                {
                    if (moveOnX == i && moveOnY == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("* ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(arrField[i, j] + " ");
                    }
                }
                Console.WriteLine("│");
            }

            Console.Write("└");
            for (var i = 0; i < XY * 2; i++)
            {
                Console.Write("─");
            }
            Console.Write("┘");
        }


        /// <summary>
        /// вывод на экран поля игрока
        /// </summary>
        /// <param name="arrField"> массив поля игрока</param>
        public static void FieldOnDisplayUser(int[,] arrField)
        {
            Console.Write("┌");
            for (var i = 0; i < XY*2; i++)
            {
                Console.Write("─");
            }
            Console.WriteLine("┐");

            for (int i = 0; i < arrField.GetLength(0); i++)
            {
                Console.Write("│");
                for (int j = 0; j < arrField.GetLength(1); j++)
                {
                    Console.Write(arrField[i, j] + " ");
                }
                Console.WriteLine("│");
            }

            Console.Write("└");
            for (var i = 0; i < XY*2; i++)
            {
                Console.Write("─");
            }
            Console.Write("┘");
        }

        /// <summary>
        /// Метод движения по полю
        /// </summary>
        /// <param name="arrField"> массив поля</param>
        /// <param name="mooveOnX">переменная движения по вертикали</param>
        /// <param name="mooveOnY">переменная движения по горизонтали</param>
        public static void MooveOnDisplay(int[,] arrField, ref int moveOnX, ref int moveOnY)
        {
            ConsoleKeyInfo PressedKey = Console.ReadKey(true);


            switch (PressedKey.Key)
            {
                case ConsoleKey.RightArrow:
                    if (moveOnY != arrField.GetLength(0) - 1)
                    {
                        moveOnY++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (moveOnY != 0)
                    {
                        moveOnY--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (moveOnX != arrField.GetLength(1) - 1)
                    {
                        moveOnX++;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (moveOnX != 0)
                    {
                        moveOnX--;
                    }
                    break;
            }
        }


    }
}