using System.IO;

namespace ejogos.Models
{
    public class EquipeBase
    {
        public void CriarPastaouArquivo(string caminho)
        {
            //Nome de uma pasta/nomedoarquivo.csv
            string pasta = caminho.Split('/')[0];

            //Se o diretório não existir, criar a pasta.
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(caminho))
            {
                File.Create(caminho);
            }

        }

    }
}
