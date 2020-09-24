using System.Collections.Generic;
using Xunit;

namespace entra_21_tests
{
    public class EleicaoTest
    {
      [Fact]
      public void nao_criar_candidatos_quando_password_for_incorreto()
      {
         var eleicao = new Eleicao();
         var candidatos = new List<string> {"Joselito"};
         var criando = eleicao.CriarCandidatos(candidatos ,"nãosei");
         Assert.Null(eleicao.Candidatos);
         Assert.False(criando);
      }
    }
}       