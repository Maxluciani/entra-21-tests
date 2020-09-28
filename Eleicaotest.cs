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
      [Fact]
      public void Votar_duas_vezes_em_candidato_Joselito()
      {
         var eleicao = new Eleicao();
         string Joselito = "Joselito";
         string Luis = "Luis Boça";
         var candidatos = new List<string>{Joselito , Luis};
         eleicao.CriarCandidatos(candidatos,"Pa$$W0rd");
          var JoselitoID = eleicao.IndentificacaoPorNome(Joselito);
          var LuisID = eleicao.IndentificacaoPorNome(Luis);

          eleicao.voto(JoselitoID);
          eleicao.voto(JoselitoID);

          var candidatoJoselito = eleicao.Candidatos.Find(x => x.id ==JoselitoID);
          var candidatoLuis = eleicao.Candidatos.Find(x => x.id == LuisID);
          Assert.Equal(2, candidatoJoselito.votos);
          Assert.Equal(0,candidatoLuis.votos);
      } [Fact]
      public void Deveria_retornar_Boça_como_vencendor()
      {
        var eleicao = new Eleicao();
        string joselito = "Joselito";
        string Luis = "Luis Boça";
        var candidatos = new List<string>{joselito, Luis};
        eleicao.CriarCandidatos(candidatos,"Pa$$W0rd");
        var JoselitoID = eleicao.IndentificacaoPorNome(joselito);
        var LuisID = eleicao.IndentificacaoPorNome(Luis);
        eleicao.voto(LuisID);
        eleicao.voto(LuisID);
        var vencedor = eleicao.GetWinners();

       Assert.Equal(1,vencedor.Count);
       Assert.Equal(LuisID ,vencedor[0].id);
       Assert.Equal(2,vencedor[0].votos);
      }
      public void Empate()
      {
        var eleicao = new Eleicao();
        string Joselito = "Joselito";
        string Luis = "Luis Boça";
        var candidatos = new List <string> {Joselito , Luis};
        eleicao.CriarCandidatos(candidatos ,"Pa$$W0rd");
        var JoselitoID = eleicao.IndentificacaoPorNome(Joselito);
        var LuisID = eleicao.IndentificacaoPorNome(Luis);
        eleicao.voto(JoselitoID);
        eleicao.voto(LuisID);
        var vencedores = eleicao.GetWinners();
        var candidatoJoselito = vencedores.Find(x => x.id == JoselitoID);
        var candidatoLuis = vencedores.Find(x => x.id == LuisID);
        Assert.Equal(1,candidatoJoselito.votos);
        Assert.Equal(1,candidatoLuis.votos);  
      }

          
    }
}       