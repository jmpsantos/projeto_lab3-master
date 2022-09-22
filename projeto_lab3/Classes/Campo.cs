using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_lab3
{
    class Campo
    {
        public List<Painel> lista_painel { get; set; }
        private int altura { get; set; }
        private int comprimento { get; set; }
        private string dificuldade { get; set; }
        private int num_minas { get; set; }

        private Status status { get; set; }

        public void gerar_minas(int altura, int comprimento, int num_minas)
        {
        }

        public void preenche_matriz(int altura, int comprimento, int num_minas)   
        {
            if (dificuldade == "Medio")
            {

                //Preenche a Matriz com os Painéis
                //Coloca minas em posições aleatórias (nº minas depende da dificuldade)
                //Define numeros dos paineis adjacentes às minas
            }
            else
            {
                //Preenche a Matriz com os Painéis
                //Coloca minas em posições aleatórias (nº minas depende da dificuldade)
                //Define numeros dos paineis adjacentes às minas
            }
        }

        public void atualizar_paineis(int altura, int comprimento, int num_minas)
        {
        }
    }

    public enum Status
    {
        EmProgresso,
        Perdeu,
        Venceu,
    }
}
