using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMarket
{
    public partial class Principal : Form
    {
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

        }
    }
}
