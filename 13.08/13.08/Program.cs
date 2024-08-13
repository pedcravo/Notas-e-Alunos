using _13._08.Aula4;

namespace _13._08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item i01 = new Item()
            {
                Qtd = 1,
                Tipo = "Borracha"
            };

            Item i02 = new()
            {
                Qtd = 2,
                Tipo = "Lápis"
            };


            Notas notasDigitadas = new();
            notasDigitadas.Nota01 = 10;
            notasDigitadas.Nota02 = 4;

            Aluno a1 = new()
            {
                Nome = "Vinicius",
                Mat = 123
            };

            a1.NotasAluno = notasDigitadas; 

            Console.WriteLine($"A nota 01 de {a1.Nome} é {a1.NotasAluno.Nota01}");

            //a1.ListaItems.Add(i01);
            //a1.ListaItems.Add(i02);
            
            a1.AdicionarItens(i01);
            a1.AdicionarItens(i02);

            a1.ListarItens();
        
        }
    }
}
