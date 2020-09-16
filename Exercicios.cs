

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
           public int Exercicio012(int n1,int n2,int n3,int n4)
           {
             //Ler 4 números inteiros e imprimir a soma dos que forem par.
             int soma = 0;
             List <int> numeros = new List <int> { };
             numeros.Add (n1);
             numeros.Add (n2);
             numeros.Add (n3);
             numeros.Add (n4);
             foreach (var item in numeros)
             {
                 if(item % 2 ==0)
                {
                    
                 soma += item;
                }
             }
                return soma;
           }
           public double Exercicio013(params int [] numeros)
           {
               var maior = 0.0;
               for (int i = 0; i < numeros.Length; i++)
               {
                   if(numeros[i] > maior)
                   {
                       maior = numeros[i];
                   }
               }
                   return maior;
           }
             public (int,int) Exercicio015(double [] numeros)
             {
                  //Ler 10 números e imprimir quantos são múltiplos de 3 e quantos são múltiplos de 5.
                var multiplos3 = 0;
                var multiplos5 = 0;
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] % 3 == 0)
                    {
                        multiplos3 ++;
                    }
                    if(numeros[i] % 5 == 0)
                    {
                        multiplos5++;
                    }
                }
                return (multiplos3, multiplos5);
             }
            public double Exercicio016(double salario)
            {
             // Ler o salário de uma pessoa e imprimir o Salário Líquido de acordo com a 
             // redução do imposto descrito ao lado:
             // Menor ou igual a R$ 600,00 - ISENTO
             // Maior que R$ 600,00 e menor ou igual a 1200 - 20% desconto
             // Maior que R$ 1.200,00 e menor ou igual a R$2000 - 25% desconto
             // Maior que R$ 2.000,00 - 30% desconto
               if (salario < 600)
               {
                 return salario;
               }
               else if( salario < 1200)
               {
                   salario = (salario * 0.8);
                   return salario;
               }
               else if(salario > 1200 && salario< 2000)
               {
                   salario = (salario * 0.75);
                   return salario;
               }
               else 
               {
                   salario = (salario * 0.7);
                   return salario;
               }
            }
            public List <int> Exercicio017(int numero)
            {
                var resultado = new List<int> ();
                for (int i = 1; i < 11; i++)
                {
                    resultado.Add (numero * i);
                }
                return resultado;
            }
        
               
           
           
               
           
            
    }
}
