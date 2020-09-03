
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
    }
}
