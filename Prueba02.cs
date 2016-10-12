using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2
{
    class Prueba02
    {
        static void Main(string[] args)
        {
            DiagonalDifference d = new DiagonalDifference();
            d.print();
        }
    }
    public class DiagonalDifference
    {
        public int matrix(string s)
        {
            int d1 = 0;                                 //resultado de la suma de la primera diagonal
            int d2 = 0;                                 //resultado de la suma de la segunda diagonal
            int dim = 1;                                //dimension de la matriz
            char[] delimiters = { ' ', '|' };           //limites para el split
            for (int x = 0; x < s.Length; x++)          //buscamos el caracter | que nos dara las dimensiones de la matriz
                if (s[x] == '|')                        //
                    dim++;                              //si encontramos el caracter aumentamos el contador
            string[] t = s.Split(delimiters);           //separamos los valores de la matriz
            for (int x = 0; x < t.Length; x+=(dim+1))   //nos movemos por el vector
                d1 += Int32.Parse(t[x]);                //convertimos de string a int
            for (int x = t.Length - dim; x > 0; x -= (dim - 1))   //recorremos de forma inversa 
                d2 += Int32.Parse(t[x]);                          //convertimos de string a int
            return d1 - d2;                                       //retornamos la diferencia de las sumas de las diagonales
        }
        public void print()
        {
            string s1 = "11 2 4|4 5 6|10 8 -12";             //Prueba con matriz de 3x3
            Console.WriteLine(matrix(s1));

            string s2 = "9 5|2 3";                           //Prueba con matriz de 2x2
            Console.WriteLine(matrix(s2));

            string s3 = "1 0 0 2|0 3 4 0|0 5 6 0|4 0 0 8";   //Prueba con matriz de 4x4
            Console.WriteLine(matrix(s3));

            Console.ReadKey();
        }
    }
}
