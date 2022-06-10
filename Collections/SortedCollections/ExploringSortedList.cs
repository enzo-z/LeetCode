using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.SortedCollections
{
    /// <summary>
    /// SortedList é um dicionário, não uma lista.
    /// O lance é que ele ordena pelas Keys do Dicionário, e no SortedList, as Keys são uma List
    /// Por isso, que ele vai demorar pra fazer remoções e adições de unsorted data. 
    /// Agora, se já for sortedData, vai ser muito rápido, porque só precisa adicionar no final.
    /// Remover, acredito que vai ser mais lento.
    /// </summary>
    internal class ExploringSortedList
    {
        internal static void MainSortedList()
        {
            IDictionary<int, Pessoa> pessoas = new SortedList<int, Pessoa>();
            var enzo = new Pessoa(10, "Enzo Zamora");
            var wesley = new Pessoa(2, "Wesley Ferreira");
            var amaral = new Pessoa(3, "Amaralindo");
            var chico = new Pessoa(4, "Chico");
            var polck = new Pessoa(5, "Elodin");
            var pedro = new Pessoa(6, "Pero Seo");

            pessoas.Add(enzo.Id, enzo); // 10
            pessoas.Add(wesley.Id, wesley); // 2
            pessoas.Add(amaral.Id, amaral); // 3
            pessoas.Add(chico.Id, chico); // 4
            pessoas.Add(polck.Id, polck); // 5
            pessoas.Add(pedro.Id, pedro); // 6

            pessoas.Remove(6);

            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
            Console.WriteLine();
            var sortList = new SortedList<int, Pessoa>(pessoas);
            Console.WriteLine(sortList[2]);

        }

    }

    internal class Pessoa
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Pessoa(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string? ToString() => $"[ID: {Id} | Nome: {Name}]";
    }
}
