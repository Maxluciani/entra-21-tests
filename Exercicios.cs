

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
    }
}
