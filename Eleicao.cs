using System;
using System.Collections.Generic;
using System.Linq;

namespace entra_21_tests
{
    public class Eleicao
    {
     public List<(Guid id,string nome,int votos)> Candidatos {get; set; }
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


    }


}   