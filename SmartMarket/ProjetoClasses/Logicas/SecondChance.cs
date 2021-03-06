﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
            Produto prod;
            Prateleira Esteira = new Prateleira(tamanhoprateleira);

            foreach (char item in sequencia)
            {
                prod = null;

                if (item != '.')
                {
                    //Se o elemento não existe no vetor e a ultima posição está nula, ou seja, podendo-se inserir novos elementos
                    if (!Esteira.VerificaExistenciaElemento(int.Parse(item.ToString()), false) &&
                        Esteira.Esteira[tamanhoprateleira - 1] == null)
                    {
                        //Adiciona o elemento ao vetor
                        AdicionarElementoPrateleira(Produtos, item.ToString(), ref Esteira);
                    }

                    //Se o elemento não existe no vetor e a ultima posição não está nula(fazendo-se a substituição de uma página)
                    else if (!Esteira.VerificaExistenciaElemento(int.Parse(item.ToString()), false) &&
                        Esteira.Esteira[tamanhoprateleira - 1] != null)
                    {
                        prod = VerificarBits(Esteira.Esteira);

                        //Não foi encontrado nenhum objeto com o bit zerado
                        if (prod == null)
                        {
                            //Deve-se zerar todo o vetor.
                            ZeraTodosOsBits(ref Esteira.Esteira);
                            //depois receber o objeto com o primeiro bit zerado
                            prod = VerificarBits(Esteira.Esteira);
                        }

                        //Retira elemento da fila
                        Esteira.RetirarElemento(Array.IndexOf(Esteira.Esteira, prod));

                        //Reorganiza os elementos no vetor
                        this.ReorganizaElementos(ref Esteira.Esteira);

                        //Adicionado o valor na fila
                        AdicionarElementoPrateleira(Produtos, item.ToString(), ref Esteira);

                    }
                }
                //Neste Trecho, elaborar alguma estrutura de dados, para ser retornada ao form, para ser exibido.
                //Como um datable, para ser populado em um datagrid.

            }
        }

        /// <summary>
        /// Método responsável por gerenciar a qual objeto deve ser inserido no vetor
        /// </summary>
        /// <param name="Produtos"></param>
        /// <param name="chave"></param>
        /// <param name="Esteira"></param>

        public void AdicionarElementoPrateleira(List<Produto> Produtos, string chave, ref Prateleira Esteira)
        {
            Produto prod;

            prod = Produtos.Find(x => x.IdProduto == int.Parse(chave.ToString()));
            Esteira.AdicionarElemento(prod, Esteira.RetornaIndiceLivre(Esteira.Esteira));
        }

        /// <summary>
        /// Reorganiza os elementos do vetor, após a retirada de um elemento
        /// </summary>
        /// <param name="prat"></param>
        private void ReorganizaElementos(ref Produto[] prat)
        {
            for (int i = 0; i <= prat.GetLength(0) - 2; i++)
            {
                if (prat[i] == null)
                {
                    prat[i] = prat[i + 1];
                    prat[i + 1] = null;
                }
            }
        }

        /// <summary>
        /// Método para identificar se existe algum elemento com Bit valendo 0
        /// </summary>
        /// <param name="prat"></param>
        public Produto VerificarBits(Produto[] prat)
        {
            //Se for diferente de nulo o retorno, identificar o primeiro objeto que contem indice 0
            return prat.Where(x => x.BitSc == 0).FirstOrDefault();
        }

        /// <summary>
        /// Método responsável por zerar todos os bits do vetor
        /// </summary>
        /// <param name="prat"></param>
        public void ZeraTodosOsBits(ref Produto[] prat)
        {
            for (int i = 0; i < prat.GetLength(0); i++)
            {
                if (prat[i] != null)
                {
                    prat[i].BitSc = 0;
                }
            }
        }
    }
}
