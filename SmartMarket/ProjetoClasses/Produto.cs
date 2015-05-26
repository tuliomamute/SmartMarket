using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasses
{
    public class Produto
    {
        public Produto(int aId, string aNome, int abitsc)
        {
            BitSc = abitsc;
            IdProduto = aId;
            NomeProduto = aNome;

        }
        public Produto()
        { }

        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int BitSc { get; set; }


        /// <summary>
        /// Método responsável por gerar a lista que contém os produtos
        /// </summary>
        /// <returns></returns>
        public static List<Produto> RetornaListaProduto()
        {
            List<Produto> prod = new List<Produto>();
            prod.Add(new Produto(0, "Coca Cola", 1));
            prod.Add(new Produto(1, "Iphone 6", 1));
            prod.Add(new Produto(2, "Tv Sony", 1));
            prod.Add(new Produto(3, "Leite", 1));
            prod.Add(new Produto(4, "Lacta", 1));
            prod.Add(new Produto(5, "Sabão", 1));
            prod.Add(new Produto(6, "Ração p/ Cachorro", 1));
            prod.Add(new Produto(7, "Cerveja", 1));
            prod.Add(new Produto(8, "Leite Ninho", 1));
            prod.Add(new Produto(9, "Biscoito", 1));

            return prod;
        }

    }
}
