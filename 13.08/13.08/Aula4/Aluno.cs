using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._08.Aula4
{
    internal class Aluno
    {

        public string Nome { get; set; }

        public int Mat { get; set; }

        public Notas NotasAluno { get; set; }

        public List<Item> ListaItems { get; set; } = new List<Item>();

        /*
        public Aluno()
        {
            ListaItems = new List<Item>();
        }
        */

        public void ListarItens()
        {
            foreach (var item in ListaItems)
            {
                //Console.WriteLine(item);
                Console.WriteLine($"Item : {item.Tipo} / Qtd: {item.Qtd}");

            }
        }

        public void AdicionarItens(Item i)
        {
            if(i != null)
                ListaItems.Add(i);
        }

    }
}
