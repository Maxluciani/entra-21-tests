using System;
using System.Collections.Generic;
using System.Linq;

namespace entra_21_tests
{
    public class Eleicao
    {
     public List<(Guid id,string nome,int votos)> Candidatos {get; private set; }
     public bool CriarCandidatos(List<string> candidatosNomes, string password)
     {
         if(password == "Pa$$W0rd")
         {
             Candidatos =candidatosNomes.Select(nome => {
                 return(Guid.NewGuid() , nome,0);
             }).ToList();
             return true;
         }
         else
         {
             return false;
         }

     }
     public Guid IndentificacaoPorNome(string nome)
     {
         return Candidatos.First(x => x.nome == nome ).id;
     }
     public void voto (Guid id)
     {
       Candidatos = Candidatos.Select ( candidato => {
           return candidato.id == id
           ? ( candidato.id,candidato.nome,candidato.votos +1)
           : candidato;
       }).ToList();
     }


        public List<(Guid id , string nomes , int votos)> GetWinners()
        {
            var vencedores = new List<(Guid id,string nomes,int votos)>{Candidatos[0]};
            for (int i = 0; i < Candidatos.Count; i++)
            {
                if (Candidatos[i].votos > vencedores[0].votos)
                {
                  vencedores.Clear();
                  vencedores.Add(Candidatos[i]);
                }
             else if (Candidatos[i].votos == vencedores[0].votos)
             {
                 vencedores.Add(Candidatos[i]);
             }    
            }
            return vencedores;
        }
    }


}   