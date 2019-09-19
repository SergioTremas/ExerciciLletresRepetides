using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] _nombre = { "S", "e", "r", "g", "i", "o", " ", "T", "r", "e", "m", "o", "s", "a" };

            foreach (string item in _nombre)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.Write("Fin Fase 1 pulsa tecla para continuar con fase 2");
            Console.ReadKey(true);
            Console.WriteLine();

            List<char> nombre = new List<char>();

            nombre.Add('S');
            nombre.Add('e');
            nombre.Add('r');
            nombre.Add('g');
            nombre.Add('i');
            nombre.Add('o');


            foreach (char item in nombre)
            {

                char caracter = char.ToUpper(item);

                if (char.IsNumber(caracter))
                {
                    Console.Write(" " + caracter + " Els noms de persones no contenen números!");

                    Console.WriteLine();
                    Console.Write("Pulsa tecla para continuar...");
                    Console.ReadKey(true);
                    Console.WriteLine();

                }
                else if (caracter == 'A' | caracter == 'E' | caracter == 'I' | caracter == 'O' | caracter == 'U')
                {

                    Console.Write(" " + caracter + ": VOCAL");
                    Console.WriteLine();

                }
                else if (caracter == ' ')
                {
                    Console.Write(" " + caracter + ": ESPAI VUIT");
                    Console.WriteLine();
                }

                else
                {
                    Console.Write(" " + caracter + ": CONSONANT");
                    Console.WriteLine();
                }

            }

            Console.WriteLine();
            Console.WriteLine("Fin Fase 2 pulsa tecla para continuar con fase 3");
            Console.ReadKey(true);

            Dictionary<char, int> mapa = new Dictionary<char, int>();

            foreach (char s in nombre)
            {

                if (!mapa.ContainsKey(s))
                {
                    mapa.Add(s, 1);
                }
                else
                {
                    mapa[s]++;
                }

            }

            foreach (char a in mapa.Keys)
            {
                Console.WriteLine(a + " = " + mapa[a]);
            }

            Console.WriteLine("Fin Fase 3 pulsa tecla para continuar con fase 4");
            Console.ReadKey(true);


            List<char> surname = new List<char>();

            surname.Add('T');
            surname.Add('r');
            surname.Add('e');
            surname.Add('m');
            surname.Add('o');
            surname.Add('s');
            surname.Add('a');




             
            
            
            List<char> Fullname =nombre.Concat(" ").Concat(surname).ToList();

            foreach (char i in Fullname)
            {
                Console.Write(i);

            }
            Console.WriteLine();


            Console.WriteLine("Fin Fase 4 ");
            Console.ReadKey(true);



        }
    }
}
