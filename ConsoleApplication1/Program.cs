using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            char sym;
            x=3;
            y = 4;
            sym = '%';
            for (int i=0;i<20;i++)
            {
                for(int j=0;j<20;j++)
                {
                    Draw(i,j,sym);
                    j++;
                }
                i++;
                i++;
            }
            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }

}
