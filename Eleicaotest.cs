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
      [Fact]
      public void criar_candidatos_quando_password_for_correto()
      {
          var eleicao = new Eleicao();
          var candidatos=new List<string>{"Joselito"};
          var criando =eleicao.CriarCandidatos(candidatos,"Pa$$W0rd");
          Assert.True(criando);

          Assert.Equal(1,eleicao.Candidatos.Count);
          Assert.Equal("Joselito",eleicao.Candidatos[0].nome);
      }
      [Fact]
      public void não_gerar_quando_os_nomes_forem_iguais()
      {
      var eleicao = new Eleicao();
      string Joselito = "Joselito";
      string Luis = "Luis Boça";
       var candidatos = new List<string> {Joselito,Luis};
       eleicao.CriarCandidatos(candidatos,"Pa$$W0rd");
       var candidatoJoselito = eleicao.IndentificacaoPorNome(Joselito);
       var candidatoLuis = eleicao.IndentificacaoPorNome(Luis);
       Assert.NotEqual(candidatoJoselito,candidatoLuis);
      }
    }
}       