using System;

namespace punto_9
{
    class Program
    {
        static void Main(string[] args)
        {

            int PESOA, PESOB, PESOC, PESOD;

            Console.WriteLine("Ingrese peso esfera A");
            PESOA = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese peso esfera B");
            PESOB = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese peso esfera C");
            PESOC = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese peso esfera D");
            PESOD = int.Parse(Console.ReadLine());

            if (PESOA == PESOB && PESOA == PESOC)
            {
                if(PESOD > PESOA)
                {
                    Console.WriteLine("La esfera D es la diferente");
                }
                else
                {
                   Console.WriteLine("La esfera A es la diferente");
                }
            }
            else
            {
                if(PESOA == PESOB && PESOA == PESOD)
                {
                    Console.WriteLine("La esfera C es la diferente");
                    if(PESOC > PESOA)
                    {
                        Console.WriteLine("Y es de mayor peso");
                    }
                    else
                    {
                        Console.WriteLine("Y es de menor peso");
                    }
                }
                else
                {
                    if(PESOA == PESOC && PESOA == PESOD)
                    {
                        Console.WriteLine("La esfera B es la diferente");
                        if(PESOB > PESOD)
                        {
                            Console.WriteLine("Y es de menor peso");
                        }
                        else
                        {
                            Console.WriteLine("Y es de menor peso");
                        }
                    }
                    else
                    {
                        Console.WriteLine("La esfera A es la diferente");
                        if(PESOA > PESOB)
                        {
                            Console.WriteLine("Y es de mayorr peso");
                        }
                        else
                        {
                            Console.WriteLine("Y es de menor peso");
                        }
                    }
                }
            }
        }
    }
}
