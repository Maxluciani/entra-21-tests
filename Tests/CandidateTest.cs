using System.Collections.Generic;
using Xunit;

namespace entra_21_tests
{

    public class CandidateTest
    {
        [Fact]
     public void quando_candidato_fornece_aluns_dados()
     {
         var name = "Joselito";
         var cpf ="788.481.000-07";
         var candidate = new Candidate(name,cpf);
         Assert.Equal(name,candidate.Name);
         Assert.Equal(cpf,candidate.CPF);
     }
      [Fact]
        public void Should_contains_votes_equals_zero()
        {
            var name = "Joselito";
            var cpf = "788.481.000-07";
            var candidate = new Candidate(name,cpf);
            Assert.Equal(0,candidate.Votes);
        }
        [Fact]
        public void Deve_conter_2_iguais_quando_votado_duas_vezes()
        {
            var name = "Joselito";
            var cpf = "788.481.000-07";
            var candidate = new Candidate(name,cpf);
             candidate.Vote();
             candidate.Vote();
             Assert.Equal(2,candidate.Votes);

        }
        [Fact]
        public void Deveria_não_gerar_ID_de_ambos_os_candidatos()
        {
            var Joselito = new Candidate ("Joselito","788.481.000-72");
            var Boça = new Candidate ("Boça","190.370.310-72");
            Assert.NotEqual(Joselito.Id, Boça.Id);

        }
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("000.050.000-00")]
        [InlineData("100.000.111-22")]

        public void Deveria_retornar_falso_quando_CPF_for_invalido(string cpf)
        {
            var Joselito = new Candidate("joselito",cpf);
            var Valido = Joselito.Validate();
            Assert.False(Valido);
        }
        [Theory]
        [InlineData("763.754.955-78")]
        [InlineData("76375495578")]
        public void Deveria_retornar_true_quando_CPF_for_valido(string cpf)
        {
          var Joselito = new Candidate("Joselito",cpf);
          var valido = Joselito.Validate();
          Assert.True(valido);
        }
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("Joselito")]
        [InlineData("Joselito 666")]
        public void Deveria_retornar_falso_quando_nome_for_invalido(string name)
        {
          var cpf_valido = "123.456.789-10";
          var candidato = new Candidate(name,cpf_valido);
          var valido = candidato.Validate();
          Assert.False(valido);

        }
        [Theory]
        [InlineData("Max Luciani","000.050.000-00")]
        public void deve_retornar_true_quando_nome_e_CPF_forem_validos(string name,string cpf)
        {
         var candidato = new Candidate(name,cpf);
         var valido = candidato.Validate();
         Assert.True(valido);
        }

    }
}
