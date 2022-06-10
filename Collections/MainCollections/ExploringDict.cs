using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.MainCollections
{
    internal class ExploringDict
    {
        internal static void MainDict()
        {

            var entramDiscord = new PessoaDict[]
            {
                new PessoaDict(4, "Rezon"),
                new PessoaDict(2, "Pedro Seco"),
                //new PessoaDict(3, "Raibolt"),
            };

            IDictionary<int, PessoaDict> myDict = new Dictionary<int, PessoaDict>()
            {
                [1] = new PessoaDict(1, "Enzo Zamora")
            };

            foreach (var p in entramDiscord)
                myDict.Add(p.Id, p);


            // Showing off new things in C# 
            myDict.TryGetValue(3, out PessoaDict? pessoa); //Declaro variavel pessoa ja no out
            Console.WriteLine($"[{pessoa?.Id} - {pessoa?.Name}]");

            Console.WriteLine();
            ImprimirDicionario(myDict);

            Console.WriteLine();

            var zamoraWhatIf = new PessoaDict(1, "Enzo Zamora"); //Exception, já tem a key 1!
            myDict.Add(zamoraWhatIf.Id, zamoraWhatIf);
            ImprimirDicionario(myDict);
        }

        private static void ImprimirDicionario(IDictionary<int, PessoaDict> myDict)
        {
            foreach (var item in myDict)
            {
                Console.WriteLine(item);
            }
        }
    }

    internal class PessoaDict
    {
        public int Id { get; }
        public string Name { get; }

        public PessoaDict(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Deconstruct(out int id, out string name)
        {
            id = Id;
            name = Name;
        }

        public override string? ToString() => $"[NOME = {Name} | ID = {Id}";

    }
}
