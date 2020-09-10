
using System.Collections.Generic;
using Xunit;

namespace entra_21_tests
{
    public class ExerciciosTest
    {
        private int anosfumante;
        private int cigarrodia;

        [Fact]
        public void Numeros_de_1_ate_10()
        {
           
            var exercises = new Exercicios();
            var result = exercises.Exercicio01A();
            var expectativa = new int[10]
            {
                1,2,3,4,5,6,7,8,9,10
            };

            for (int i = 0; i < expectativa.Length; i++)
            {
                Assert.Equal(expectativa[i], result[i]);
            }
        }
         [Fact]
        public void Numeros_de_10_ate_1()
        {
            var exercicios = new Exercicios();
            int [] retornar = exercicios.Exercicio01B();
            var expectativa = new int [10]{
                10,9,8,7,6,5,4,3,2,1
            };
         for (int i = 0; i < expectativa.Length; i++)
         {
             Assert.Equal(expectativa[i],retornar[i]);
         }   
        }
         [Fact]
        public void Numeros_pares_0_ate_10()
        {
            var exercicios = new Exercicios();
            int[] retornar = exercicios.Exercicio01C();
            var expectativa = new int[5]{
                2,4,6,8,10
            };
            Assert.Equal(5, retornar.Length);
            for (int i = 0; i < expectativa.Length; i++)
            {
                Assert.Equal(expectativa[i],retornar[i]);
            }
        }
        [Fact]
        public void Soma_entra_todos_os_numeros_interos_entre_1_e_100()
        {
          //Imprimir a soma dos números inteiros de 1 a 100.
            var exercicios = new Exercicios();
            var soma = exercicios.Exercicio02();
            Assert.Equal(5050,soma);
             
        }
        [Fact]
        public void Impares_de_0_ate_200()
        {
            var exercicios = new Exercicios();
            var Lista = new List<int>(){1,3,5,7,9,11,13,15,17,19,21,23,25,
            27,29,31,33,35,37,39,41,43,45,47,49,51,53,55,57,59,61,63,65,67,
            69,71,73,75,77,79,81,83,85,87,89,91,93,95,97,99,101,103,105,107,
            109,111,113,115,117,119,121,123,125,127,129,131,133,135,137,139,
            141,143,145,147,149,151,153,155,157,
            159,161,163,165,167,169,171,173,175,177,179,181,183,185,187,189,191,193,195,197,199};
            int resultado = exercicios.Exercicio03(Lista);
            Assert.Equal(Lista,Lista);
        }
        [Fact]
        public void Media_de_idade()
        {
            var exercicios = new Exercicios();
            var Lista = new List<int>(){10,15,20};
            double resultado = exercicios.Exercicio04(Lista);
            Assert.Equal(15, resultado);
        }
        [Fact]
        public void Mulheres_entre_18_e_35_anos()
        {
            var exercicios = new Exercicios();
            var Lista = new List<int>(){15,25,30,38,40};
            int resultado = exercicios.Exercicio05(Lista);
            Assert.Equal(40,resultado);
            
        }
        [Theory]
        [InlineData(20,3,8.0)]
        public void Gasto_de_um_fumante(int cigarrodia,int anosfumante ,double preco)
        {
            var exercicios = new Exercicios();
            double resultado = exercicios.Exercicio07(cigarrodia,anosfumante,preco);
            cigarrodia = 20;
            anosfumante = 3;
            Assert.Equal(8760,resultado);
            
        }

    }
}
