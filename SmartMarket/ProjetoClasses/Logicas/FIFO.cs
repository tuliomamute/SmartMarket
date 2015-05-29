using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasses.Logicas
{
    public class FIFO
    {
        /// <summary>
        /// Método responsável por inicializar a operação do algoritmo Fifo - First In First Out
        /// </summary>
        /// <param name="sequencia">sequencia que deverá ser inserida no vetor</param>
        /// <param name="tamanhoprateleira">tamanho do array de esteira</param>

        public void IniciarProcessamento(string sequencia, int tamanhoprateleira)
        {

            List<Produto> Produtos = Produto.RetornaListaProduto();
            Produto prod;
            Prateleira Esteira = new Prateleira(tamanhoprateleira);

            foreach (char item in sequencia)
            {
                if (item != '.')
                {
                    //Se o elemento não existe no vetor e a ultima posição está nula, ou seja, podendo-se inserir novos elementos
                    if (!Esteira.VerificaExistenciaElemento(int.Parse(item.ToString())) &&
                        Esteira.Esteira[tamanhoprateleira - 1] == null)
                    {
                        //Adiciona o elemento ao vetor
                        prod = Produtos.Find(x => x.IdProduto == int.Parse(item.ToString()));
                        Esteira.AdicionarElemento(prod, Esteira.RetornaIndiceLivre(Esteira.Esteira));

                    }
                    //Se o elemento não existe no vetor e a ultima posição não está nula(fazendo-se a substituição de uma página)
                    else if (!Esteira.VerificaExistenciaElemento(int.Parse(item.ToString())) &&
                        Esteira.Esteira[tamanhoprateleira - 1] != null)
                    {
                        //Retira o elemento da primeira posição
                        Esteira.RetirarElemento(0);

                        //Realiza o deslocamento das posições
                        this.ReorganizaElementos(ref Esteira.Esteira);

                        //Adiciona o elemento ao vetor
                        prod = Produtos.Find(x => x.IdProduto == int.Parse(item.ToString()));
                        Esteira.AdicionarElemento(prod, Esteira.RetornaIndiceLivre(Esteira.Esteira));

                    }

                }

                //Neste Trecho, elaborar alguma estrutura de dados, para ser retornada ao form, para ser exibido.
                //Como um datable, para ser populado em um datagrid.

            }

        }

        /// <summary>
        /// Reorganiza os elementos do Vetor após uma substituição de página
        /// </summary>
        /// <param name="prat">Array de Prateleira</param>
        public void ReorganizaElementos(ref Produto[] prat)
        {
            for (int i = 0; i < prat.GetLength(0); i++)
            {
                if (i == prat.GetLength(0) - 1)
                {
                    prat[i] = null;
                }
                else
                {
                    prat[i] = prat[i + 1];

                }
            }
        }
    }
}
