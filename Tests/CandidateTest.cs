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

    }
}
