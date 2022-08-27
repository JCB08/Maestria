using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables 
            int b, a, area, num;
            float area2;
            string si;
            do {

            //Menu de las Figuras 
            Console.WriteLine("Elija una figura geometrica");
            Console.WriteLine("1.circulo");
            Console.WriteLine("2.triangulo");
            Console.WriteLine("3.cuadrado");

            //Lectura del Menu
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ponga la base o el lado");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pongo la altura o el lado");
            a = Convert.ToInt32(Console.ReadLine());

            //Operaciones
            switch (num)
            {  
                case 1:
                    area2=(float) (b * a * 3.14);
                    Console.WriteLine("el area del circulo es: " + area2);
                    break;

                case 2:
                    area = b * a / 2;
                    Console.WriteLine("el area del triangulo es: " + area);
                    break;

                case 3:
                    area = b * a;
                    Console.WriteLine("el area del cuadrado es :" + area);
                    break;
            }
            Console.WriteLine("desea volver a intentalo");
            si = Console.ReadLine();
        }
        while (si == "SI" || si == "si");
        
        }
    }
}
