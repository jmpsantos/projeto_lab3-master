using projeto_lab3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_lab3
{
    public partial class Form1 : Form
    {
        internal List<Jogador> lista_jogadores { get; set; }

        private bool primeiro_mov { get; set; }

        private bool fim_do_jogo { get; set; }

        private bool vitoria { get; set; }

        private Campo CampoDeJogo { get; set; }

        private int tempo_s { get; set; }

        void ResetGame()
        {

        }

        void StartGame()
        {

        }


        int EndGame()
        {
            if (vitoria == true)
            {
                SaveFilePlayer();
            }

            PararRelogio();
            return tempo;
        }

        void SaveFilePlayer()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void jogoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

    public Form1()
        {
            InitializeComponent();

            lista_jogadores = new List<Jogador>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
