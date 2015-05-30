using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasses
{
    public class Produto
    {
        /// <summary>
        /// Construtor de Objeto Produto, para criar um objeto do tipo produto
        /// </summary>
        /// <param name="aId"></param>
        /// <param name="aNome"></param>
        /// <param name="abitsc"></param>
        public Produto(int aId, string aNome)
        {
            this.BitSc = 1;
            this.IdProduto = aId;
            this.NomeProduto = aNome;
            this.ControleLRU = -1;
        }
        public Produto()
        { }

        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int BitSc { get; set; }
        public int ControleLRU { get; set; }
        /// <summary>
        /// Método responsável por gerar a lista que contém os produtos
        /// </summary>
        /// <returns></returns>
        public static List<Produto> RetornaListaProduto()
        {
            List<Produto> prod = new List<Produto>();
            prod.Add(new Produto(0, "Coca Cola"));
            prod.Add(new Produto(1, "Iphone 6"));
            prod.Add(new Produto(2, "Tv Sony"));
            prod.Add(new Produto(3, "Leite"));
            prod.Add(new Produto(4, "Lacta"));
            prod.Add(new Produto(5, "Sabão"));
            prod.Add(new Produto(6, "Ração p/ Cachorro"));
            prod.Add(new Produto(7, "Cerveja"));
            prod.Add(new Produto(8, "Leite Ninho"));
            prod.Add(new Produto(9, "Biscoito"));

            return prod;
        }

    }
}
