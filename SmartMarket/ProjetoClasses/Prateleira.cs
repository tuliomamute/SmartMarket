using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasses
{
    class Prateleira
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
    }

}
