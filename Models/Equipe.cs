using EJOGOS.Interface;
using System.Collections.Generic;
using System.IO;

namespace EJOGOS.Models
{



    public class Equipe : EquipeBase, IEquipe
    {
        public int idEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }



        private const string caminhobd = "Database/equipe.csv";
        private string valor;

        public Equipe()
        {
            

            CriarPastaOuArquivo(caminhobd);

        }


        private string Preparar(Equipe e)
        {
            return e.idEquipe + ";" + e.Nome + ";" + e.Imagem;

        }









        public void Criar(Equipe novaequipe)
        {

            string valor =  Preparar(novaequipe);

            string[] equipe_texto = { valor };

            File.AppendAllLines(caminhobd, equipe_texto);

        }

        public List<Equipe> LerEquipes()
        {
            List<Equipe> ListaEquipes = new List<Equipe>();

            string[] linhas = File.ReadAllLines(caminhobd);

            foreach (string item in linhas)
            {
                string[] linhaEquipe = item.Split(';');

                Equipe equipeAtual = new Equipe();

                equipeAtual.idEquipe = int.Parse(linhaEquipe[0]);
                equipeAtual.Nome = linhaEquipe[1];
                equipeAtual.Imagem = linhaEquipe[2];

                ListaEquipes.Add(equipeAtual);

                                

            }

            return ListaEquipes;

        }
    }
}
