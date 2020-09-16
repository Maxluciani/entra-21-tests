
using System.Collections.Generic;
using Xunit;

namespace entra_21_tests
{
    public class ExerciciosTest
    {
       
        

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
         [Theory]
         [InlineData(10,5,2)]
        public void É_multiplo(double x,double y , double sim)
        {
         var exercicios = new Exercicios();
         double resultado = exercicios.Exercicio08(x,y,sim);
          Assert.Equal(2,resultado);
        }
        [Theory]
        [InlineData(10,4,5,11,true)]
        public void Primeiro_é_maior_que_segundo_mais_terceiro(int n1,int n2,int n3,int soma,bool resultadoo)
        {
            var exercicios = new Exercicios();
            var resultado = exercicios.Exercicio09(n1,n2,n3,soma,resultadoo);
            Assert.Equal(n1,resultado);

        }
        [Theory]
        [InlineData (5,3,true)]
        public void A_maior_que_B(int n1,int n2,bool conclusao)
        {
          var exercicios = new Exercicios();
          var resultado = exercicios.Exercicio010Amaior(n1,n2);
          Assert.Equal(conclusao,resultado);
        }
         [Theory]
        [InlineData (5,8,true)]
        public void B_maior_que_A(int n1,int n2,bool conclusao)
        {
        var exercicios = new Exercicios();
        var resultado = exercicios.Exercicio010Bmaior(n1,n2);
        Assert.Equal(conclusao,resultado);

        }
        [Theory]
        [InlineData (6,2,3)]
        public void A_dividido_B(int n1,int n2,int resultado)
        {
            var exercicios = new Exercicios();
            var expectativa = exercicios.Exercicio011(n1,n2,resultado);
            
            Assert.Equal(expectativa,resultado);

        }
         [Theory]
        [InlineData (5,8,10,9,18)]
        public void Soma_dos_pares(int n1,int n2,int n3,int n4,int resultado)
        {
            var exercicios = new Exercicios();
            var expectativa = exercicios.Exercicio012(n1,n2,n3,n4);
            Assert.Equal(expectativa,resultado);
        }
         [Fact]
         public void Maior_numero()
         {
             var exercicios = new Exercicios();
             var maior = exercicios.Exercicio013( 5,65,32,99,87,4,12,96,33,65,68);
             Assert.Equal(99,maior);
         }
          [Fact]
         public void Multiplos_de_3_e_5()
         {
             var exercicios = new Exercicios();
             var numeros = new double [10] {15,20,25,27,7,6,30,96,-15,11};
             var resultado = exercicios.Exercicio015(numeros);
             // multplos de 3 == 6
             // multiplos de 5 == 5
             var expectativa = (6,5);
             Assert.Equal(expectativa,resultado);

         }
         [Theory]
        [InlineData (2000,1400)]
        public void Salario_limpo(double salario , double salariolimpo)
        {
         var exercicios = new Exercicios();
         var resultado = exercicios.Exercicio016(salario);
         Assert.Equal(resultado,salariolimpo);
        }
        [Fact]
        public void Tabuada_de_um_numero()
        {
            var exercicios = new Exercicios();
            var resultado = exercicios.Exercicio017(3);
            Assert.Collection(resultado,
            i1 =>{Assert.Equal(3,i1);},
            i2 =>{Assert.Equal(6,i2);},
            i3 =>{Assert.Equal(9,i3);},
            i4 =>{Assert.Equal(12,i4);},
            i5 =>{Assert.Equal(15,i5);},
            i6 =>{Assert.Equal(18,i6);},
            i7 =>{Assert.Equal(21,i7);},
            i8 =>{Assert.Equal(24,i8);},
            i9 =>{Assert.Equal(27,i9);},
            i10 =>{Assert.Equal(30,i10);}
            );
            
        }
    }
}
