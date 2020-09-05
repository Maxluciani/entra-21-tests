

using System.Collections.Generic;

namespace entra_21_tests
{
    public class Exercicios
    {
       
        public int[] Exercicio01A()
           {
            var numeros = new int[10];

            for (int counter = 1; counter < 11; counter++)
            {
				numeros[counter - 1] = counter;
            }

            return numeros;
        }
        public int[] Exercicio01B()
        {
            var numeros = new int [10];
            for (int i = 10; i > 0; i--)
            {
                numeros[numeros.Length - i] = i;
            }
            return numeros;
        }
        public int[] Exercicio01C()
        {
            var numeros = new int [5];
            for (int i = 2; i < 11; i+=2)
            {
               var index = (i / 2) - 1;
               numeros[index] = i; 
            }
            return numeros;
        }
        public int Exercicio02()
        {
          
          var soma = 0;
         for (int i = 0; i < 101; i++)
         {
             soma+= i;
         }
          return soma;
        }
        public double Exercicio04(List<int> ages)
        {
           double soma = 0.0;
           var quantidade = ages.Count;
           foreach (var item in ages)
           {
            soma += item;   
           }
           var media = (soma / quantidade);
          return media;
        }
         public int Exercicio03(List<int> Lista)
         {
           var impares = 0;
           impares = Lista.Count;
           return impares;
         }
    }
}
