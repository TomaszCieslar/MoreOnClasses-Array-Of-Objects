using System;

namespace MoreOnClasses_Array_Of_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a class named "Table". It must have a constructor, indicating the width and height of the board.
            //It will have a method "ShowData" which will write on the screen the width and that height of the table. 
            //Create an array containing 10 tables, with random sizes between 50 and 200 cm, and display all the data.

            Table[] ArrayOfTables = new Table[10];

            for (int i = 0; i < ArrayOfTables.Length; i++)
            {
                Random rnd = new Random();
                ArrayOfTables[i] = new Table(rnd.Next(50, 201), rnd.Next(50, 201));
                ArrayOfTables[i].ShowData();
            }

            Console.ReadLine();

        }
    }
}
