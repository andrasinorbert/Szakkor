using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        struct Pont
        {
            public int x;
            public int y;
            public int z;

            public override string ToString()
            {
                return  "("+x+","+
                            y+ "," +
                            z+ ")";
            }
        }

        static void vonal(int hossz=20)
        {
            string vonal = "";
            for (int i = 0; i < hossz; i++)
                vonal += "-";
            Console.WriteLine(vonal);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("szia");
            Console.Write("Hello");
            Console.WriteLine();
            Console.WriteLine("Adj meg egy szöveget!");
            string input = Console.ReadLine();
            Console.Write("Ezt adtad meg: ");
            Console.WriteLine(input);

            int x = 5;
            int y = 2;
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / (float)y);

            Pont p= new Pont();
            p.x = 5;
            p.y = 2;
            p.z = 3;

            Console.WriteLine(x.ToString());
            Console.WriteLine(p.ToString());
            Console.WriteLine($"({p.x},{p.y},{p.z})");
            Console.WriteLine("({0},{1},{2})",
                                p.x, p.y, p.z);

            int[] t = { 2, 6, 4, 1, 8, 4, 9 };
            for(int i=0; i < t.Length; ++i)
            {
                Console.WriteLine(t[i]);
            }
            vonal();
            int j = 0;
            for ( ; ; )
                if(j < t.Length) Console.WriteLine(t[j++]);
                else break;
            vonal();

            for (int i = 0; i < t.Length; ++i)
                Console.WriteLine(t[i]);

            vonal(20);
            //komment
            /*
                ez
                egy
                több
                soros
                komment
            */

            //összegzés tétele
            t =new int[]{ 3,6,7,8,3,5};
            int sum = 0;
            foreach (int i in t)
                sum *= i;
            Console.WriteLine("Az elemek összege: {0}", sum);

            // prog alap jegyzet: https://progalap.elte.hu/?El%C5%91ad%C3%A1s
        }
    }
}