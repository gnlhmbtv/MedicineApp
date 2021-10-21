using System;
using System.Collections.Generic;
using System.Text;

namespace Utilies.Helper
{
    public static class Helper
    {
        public static void ChangeTextColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
