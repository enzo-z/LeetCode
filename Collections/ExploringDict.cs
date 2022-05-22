using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class ExploringDict
    {
        internal static void Main() 
        {

            var ticoTeco = new PessoaDict[]
            {
                new PessoaDict(3, "Raibolt"),
                new PessoaDict(4, "Rezon"),
            };

            var myDict = new Dictionary<int, PessoaDict>()
            {
                [1] = new PessoaDict(1, "Enzo Zamora")
            };
            var peroSeo = new PessoaDict(2, "Pedro Seco");

            foreach (var p in ticoTeco)
            {
                myDict.Add(p.Id, p);
            }

            PessoaDict pessoa = null;
            Console.WriteLine( myDict.TryGetValue(3, out pessoa));
            Console.WriteLine(pessoa.Id + pessoa.Name);


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

        public override bool Equals(object? obj)
        {
            return obj is PessoaDict pessoa &&
                   Id == pessoa.Id;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return Id.GetHashCode();
            }
        }
    }
}
