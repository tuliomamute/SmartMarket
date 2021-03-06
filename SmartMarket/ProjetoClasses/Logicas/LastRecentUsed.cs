﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasses.Logicas
{
    public class LastRecentUsed
    {
        /// <summary>
        /// Método responsável por inicializar a operação do algoritmo Fifo - First In First Out
        /// </summary>
        /// <param name="sequencia">sequencia que deverá ser inserida no vetor</param>
        /// <param name="tamanhoprateleira">tamanho do array de esteira</param>

        public void IniciarProcessamento(string sequencia, int tamanhoprateleira)
        {
            List<Produto> Produtos = null;
            Prateleira Esteira = new Prateleira(tamanhoprateleira);

            foreach (char item in sequencia)
            {
                Produtos = Produto.RetornaListaProduto();

                if (item != '.')
                {
                    //Se houver posição disponível para inserir novos objetos
                    if (Esteira.Esteira[tamanhoprateleira - 1] == null)
                    {
                        //Se o elemento não estiver no vetor, insere-o
                        if (!Esteira.VerificaExistenciaElemento(int.Parse(item.ToString()), true))
                        {
                            AdicionarElementoPrateleira(Produtos, item.ToString(), Esteira);
                            AlterarIdentificadorTempo(Esteira.Esteira);

                        }
                        else
                        {
                            //Remove o elemento, para poder zerar o contador
                            Esteira.RetirarElemento(RetornaIndiceTroca(item.ToString(), Esteira.Esteira));
                            //Adiciona o elemento ao vetor, após ter sido retirado
                            AdicionarElementoPrateleira(Produtos, item.ToString(), Esteira);

                            //Altera o identificador de tempo
                            AlterarIdentificadorTempo(Esteira.Esteira);
                        }
                    }
                    else
                    {
                        //Realiza a troca do produto, pelo que está fora do vetor
                        if (!Esteira.VerificaExistenciaElemento(int.Parse(item.ToString()), true))
                        {
                            //Retira o elemento do vetor, baseado no indicador de tempo sendo mais antigo
                            Esteira.RetirarElemento(RetornaIndiceMaisAntigo(Esteira.Esteira));

                            //Adiciona o novo elemento, na posição vaga
                            AdicionarElementoPrateleira(Produtos, item.ToString(), Esteira);

                            //Executa o metodo que irá alterar os valores de tempo
                            AlterarIdentificadorTempo(Esteira.Esteira);
                        }
                        else
                        {
                            //Se ele estiver no vetor, a troca de posição já foi feita.
                            //bastando executar o algoritmo para alterar o tempo dos objetos.
                            AlterarIdentificadorTempo(Esteira.Esteira);
                        }
                    }
                }
            }
        }

        private int RetornaIndiceTroca(string chave, Produto[] prat)
        {
            for (int i = 0; i < prat.GetLength(0); i++)
            {
                if (prat[i].IdProduto == int.Parse(chave))
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Método responsável por validar o identificador de tempo
        /// </summary>
        /// <param name="produto"></param>
        private void AlterarIdentificadorTempo(Produto[] prat)
        {
            for (int i = 0; i < prat.GetLength(0); i++)
            {
                ///Será somado no identificador se a posição conter um objeto valido
                ///e o identificador for menor do que a quantidade de elementos - 1
                if (prat[i] != null && prat[i].ControleLRU < prat.GetLength(0) - 1)
                {
                    prat[i].ControleLRU = prat[i].ControleLRU + 1;
                }
            }
        }

        /// <summary>
        /// Método responsável por gerenciar a qual objeto deve ser inserido no vetor
        /// </summary>
        /// <param name="Produtos"></param>
        /// <param name="chave"></param>
        /// <param name="Esteira"></param>
        public void AdicionarElementoPrateleira(List<Produto> Produtos, string chave, Prateleira Esteira)
        {
            Produto prod = null;

            prod = Produtos.Find(x => x.IdProduto == int.Parse(chave.ToString()));

            Esteira.AdicionarElemento(prod, Esteira.RetornaIndiceLivre(Esteira.Esteira));
        }

        public int RetornaIndiceMaisAntigo(Produto[] prat)
        {
            for (int i = 0; i < prat.GetLength(0); i++)
            {
                if (prat[i] != null)
                {
                    if (prat[i].ControleLRU == prat.GetLength(0) - 1)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

    }
}
