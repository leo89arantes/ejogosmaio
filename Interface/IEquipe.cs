using ejogos.Models;
using System.Collections.Generic;

namespace ejogos.Interface
{
    public interface IEquipe
    {
        //Contrato, representa os métodos que são obrigatórios em um classe.

        void Criar(Equipe novaequipe);

        List<Equipe> LerEquipes();


    }
}
