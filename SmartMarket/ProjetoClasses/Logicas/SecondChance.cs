using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasses.Logicas
{
   public class SecondChance
    {
        /// <summary>
        /// Método responsável por inicializar a operação do algoritmo Fifo - First In First Out
        /// </summary>
        /// <param name="sequencia">sequencia que deverá ser inserida no vetor</param>
        /// <param name="tamanhoprateleira">tamanho do array de esteira</param>

        public void IniciarProcessamento(string sequencia, int tamanhoprateleira)
        {

            List<Produto> Produtos = Produto.RetornaListaProduto();

            Prateleira Esteira = new Prateleira(tamanhoprateleira);

        }
    }
}
