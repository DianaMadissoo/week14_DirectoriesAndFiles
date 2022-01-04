using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\diana\Desktop\Programmeerimise alused\Samples";
            string newDirectory = ($"ShoppingList");
            string fileName = ($"myShoppingList.txt");


            Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
            File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");

            

        }
    }
}
