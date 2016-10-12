using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3
{
    class Prueba03
    {
        static void Main(string[] args)
        {
            CamelCase c = new CamelCase();
            c.print();
        }
    }
    public class CamelCase
    {
        public int calculate(string s)
        {
            int contador = 1;
            for (int x = 0; x < s.Length; x++)   //recorremos el string
                if (Char.IsUpper(s[x]))          //si encontramos una mayuscula 
                    contador++;                  //aumentamos el contador
            return contador;                     //retornamos la cantidad de palabras
        }
        public void print()
        {
            string t1 = "saveChangesInTheEditor";
            Console.WriteLine("Cantidad de palabras: {0}",calculate(t1));

            string t2 = "davidFranciscoMejiaCascante";
            Console.WriteLine("Cantidad de palabras: {0}", calculate(t2));

            string t3 = "howManyWordsAreInThisSentence";
            Console.WriteLine("Cantidad de palabras: {0}", calculate(t3));

            Console.ReadKey();
        }
    }
}
