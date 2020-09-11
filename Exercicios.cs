

using System.Collections.Generic;

namespace entra_21_tests
{
    public class Exercicios
    {
       
        public int[] Exercicio01A()
         //Os números de 1 a 10 de forma crescente
        {
            var numeros = new int[10];

            for (int counter = 1; counter < 11; counter++)
            {
				numeros[counter - 1] = counter;
            }

            return numeros;
        }
        public int[] Exercicio01B()
         //Os números de 1 a 10 de forma descrecente
        {
            var numeros = new int [10];
            for (int i = 10; i > 0; i--)
            {
                numeros[numeros.Length - i] = i;
            }
            return numeros;
        }
        public int[] Exercicio01C()
         //Os números de 1 a 10 de forma crescente, mas apenas aqueles
         //que forem par.
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
        //Imprimir a soma dos números inteiros de 1 a 100.
        {
          
          var soma = 0;
         for (int i = 0; i < 101; i++)
         {
             soma+= i;
         }
          return soma;
        }
         public int Exercicio03(List<int> Lista)
         //Imprimir todo os números ímpares menores de 200.
         {
           var impares = 0;
           impares = Lista.Count;
           return impares;
         }
        public double Exercicio04(List<int> ages)
         //Calcular a média de idade de uma turma qualquer. O algoritmo deve parar 
        //quando for digitada a idade igual a zero.
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
        public int Exercicio05(List<int> idades)
        {
          //Criar um algoritmo que peça o nome e a idade de 5 mulheres. Após 
         //informar estes dados, o programa deve mostrar apenas porcentagem de
         // mulheres que estão com idade entre 18 e 35
         var total = 0;
         var mulheres = 0;
         foreach (var item in idades)
         {
             
             if(item > 17 && item < 36)
             {
                mulheres += idades.Count;
             }
         }   
          total = (mulheres *100 / 25);
         
         return total;
    
        } 
        public double Exercicio07(
            int cigarrodia,
            int anosfumante,
            double preco)
        {
         //Calcular a quantidade de dinheiro gasta por um fumante. 
	     //Dados: o numero de anos que ele fuma, o nº de cigarros fumados por 
         //dia e o preço de uma carteira.
         
         var cigarroanual = 0.0;
         var varejo = (preco / 20);
          cigarroanual = (varejo * cigarrodia) * 365;
          double total = (cigarroanual * anosfumante);
          return total;
        }
         public double Exercicio08(double x,double y,double sim)
         {
           //Ler dois números inteiros, X e Y, e apresentar mensagem 
           //informando se o X é múltiplo de Y.
           sim = (x / y);
           return sim;
         }
         public int Exercicio09(int n1,int soma,int n2,int n3,bool resultadoo)
         { 
            
             //Fazer um algoritmo para ler 03 números reais do teclado e verificar se o  
		 //primeiro é maior que a soma dos outros dois.
              
              soma = n2 + n3;
          if (n1 > soma)
          {
                 resultadoo = true;
          }

              return n1;
         }
          public bool Exercicio010Amaior(int n1,int n2) => n1 > n2;
          public bool Exercicio010Bmaior(int n1,int n2) => n2 > n1;

          
             //Ler 02 números reais do teclado (A e B),
			//verificar e imprimir qual deles é maior, ou a mensagem "A = B" caso sejam iguais
            
          public int Exercicio011(int n1,int n2,int resultado)
          {
             //Ler 02 números inteiros do teclado. Se o segundo for diferente de zero,
			// calcular e imprimir o quociente do primeiro pelo segundo.
           
            if(n2 != 0)
            {
                resultado = n1 / n2;
            }
               return resultado;
          }

          
        
               
           
           
               
           
            
    }
}
