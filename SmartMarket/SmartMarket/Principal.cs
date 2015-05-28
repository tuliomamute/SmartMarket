using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoClasses;
using ProjetoClasses.Logicas;
using System.IO;

namespace SmartMarket
{
    public partial class Principal : Form
    {
        /// <summary>
        /// Sequencia de valores a serem inseridos na prateleira
        /// </summary>
        private string SequenciaValores;
        /// <summary>
        /// Tamanho da Prateleira
        /// </summary>
        private int TamanhoPrateleira;

        public Principal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento do Botão de Upload de Arquivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpload_Click(object sender, EventArgs e)
        {
            FolderBuscarArquivo.AddExtension = true;
            FolderBuscarArquivo.ShowDialog();
            TxtEndArquivo.Text = FolderBuscarArquivo.FileName;


        }

        /// <summary>
        /// Evento do botão de Executar Algoritmo escolhido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExecutar_Click(object sender, EventArgs e)
        {
            try
            {
                LerArquivoTxt();

                if (RButFIFO.Checked)
                {
                    FIFO AlgoritmoFifo = new FIFO();
                    AlgoritmoFifo.IniciarProcessamento(SequenciaValores, TamanhoPrateleira);
                }

                if (RButSecondChance.Checked)
                {
                    SecondChance AlgoritmoSC = new SecondChance();
                    AlgoritmoSC.IniciarProcessamento(SequenciaValores, TamanhoPrateleira);
                }

                if (RButLRU.Checked)
                {
                    LastRecentUsed AlgoritmoLRU = new LastRecentUsed();
                    AlgoritmoLRU.IniciarProcessamento(SequenciaValores, TamanhoPrateleira);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Um erro foi identificado, gentileza contactar o suporte.\n Mensagem: {0}",
                                ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        /// <summary>
        /// Leitura de Arquivo Txt para recuperação dos valores, setando nas propriedades corretas.
        /// </summary>
        private void LerArquivoTxt()
        {
            StreamReader arquivo = null;
            try
            {
                arquivo = new StreamReader(TxtEndArquivo.Text);

                TamanhoPrateleira = int.Parse(arquivo.ReadLine());
                SequenciaValores = arquivo.ReadLine();

            }
            finally
            {
                if (arquivo != null)
                {
                    arquivo.Close();
                    arquivo = null;
                }
            }

        }
    }
}
