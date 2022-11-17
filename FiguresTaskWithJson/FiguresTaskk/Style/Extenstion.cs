using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Style
{
    static public class Extenstion
    {
        static public void Alert(ConsoleColor color, string str)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ResetColor();
        }
        static public int IntIsValid()
        {
            int n=0;
            bool isValid = true;
            while(isValid)
            {
                bool intIsParsed = int.TryParse(Console.ReadLine(), out n);
                if(intIsParsed)
                {
                    isValid = false;
                }
                else
                {
                    Extenstion.Alert(ConsoleColor.DarkYellow, "Try again!");
                }
            }
            return n;
        }
    }
}
