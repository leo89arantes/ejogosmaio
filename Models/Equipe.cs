using ejogos.Interface;
using System.Collections.Generic;
using System.IO;

namespace ejogos.Models
{
    //Herança 


    public class Equipe : EquipeBase, IEquipe
    {
        public int idEquipe { get; set; }

        public string Nome { get; set; }

        public string Imagem { get; set; }

        //váriavel de dados.

        private const string caminhobd = "Database/equipe.csv";

        public Equipe()
        {
            //método da classe de herança EquipeBase
            CriarPastaouArquivo(caminhobd);
        }

        //Criar uma função que vai receber o objeto EQUIPE, e vai retornar no formato CSV. (STRING)

        private string Preparar(Equipe e)
        {
            return e.idEquipe + "; " + e.Nome + "; " + e.Imagem;
            //return $"{e.idEquipe"; " {e.Nome}; "; "{e.Imagem}"; //outra forma de retornar
        }








        public void Criar(Equipe novaequipe)
        {
            string valor = Preparar(novaequipe);

            //array de strigs = na posição 0 temos o retorno do "Preparar".
            string[] equipe_texto = {Preparar(novaequipe)};

            //arquivo vamos adicionar uma nova linha. Vai receber o caminho do arquivo e uma string em formato de Array.
            File.AppendAllLines(caminhobd, equipe_texto);




        }

        public List<Equipe> LerEquipes()
        {
            List<Equipe> listaEquipes = new List<Equipe>();

            //ler todas as linhas do arquivo csv, armazenar em um array;
            string [] linhas = File.ReadAllLines(caminhobd);

            foreach (string item in linhas)
            {
                //1; nome a equipe; caminho da imagem

                string[] linhaEquipe = item.Split(';');

                Equipe equipeAtual = new Equipe();
                equipeAtual.idEquipe = int.Parse(linhaEquipe[0]);
                equipeAtual.Nome = linhaEquipe[1];
                equipeAtual.Imagem = linhaEquipe[2];

                listaEquipes.Add(equipeAtual);                
            }
            return listaEquipes;
        }
    }
}
