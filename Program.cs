using System;
namespace New_C_Sharp
{
    class Test
    {
        static void Main()
        {
            int d, m, y;
            d = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if (m == 4 || m == 6 || m == 9 || m == 11)
                if (d < 30)
                    d++;
                else
                {
                    d = 1;
                    m++;
                }
            else if (m == 2)
                if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
                    if (d < 29)
                        d++;
                    else
                    {
                        d = 1;
                        m++;
                    }
                else if (d < 28)
                    d++;
                else
                {
                    m++;
                    d = 1;
                }
            else if (d < 31)
                d++;
            else if(m==12)
            {
                d = 1;
                m = 1;
                y++;
            }
            else
            {
                d = 1;
                m++;
            }
            Console.WriteLine(d +"/" +m+ "/" +y);
        }
    }
}