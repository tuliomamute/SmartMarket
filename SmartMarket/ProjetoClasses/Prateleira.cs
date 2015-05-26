using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasses
{
    public class Prateleira
    {
        public Produto[] Esteira;

        /// <summary>
        /// Inicializa o Vetor de Esteira
        /// </summary>
        /// <param name="TamanhoArray">Tamanho do vetor contido no arquivo</param>
        public Prateleira(int TamanhoArray)
        {
            Esteira = new Produto[TamanhoArray];
        }

        /// <summary>
        /// Adiciona um elemento ao vetor
        /// </summary>
        /// <param name="prod">Objeto que deve ser adicionado</param>
        public void AdicionarElemento(Produto prod)
        {
            Esteira[Esteira.GetLength(0) - 1] = prod;
        }

        /// <summary>
        /// Retira os Elementos do vetor, baseado no indice desejado
        /// </summary>
        /// <param name="indice">Indice onde se encontra o objeto a ser retirado</param>
        public void RetirarElemento(int indice)
        {
            Esteira[indice] = null;
            
        }

    }

}
