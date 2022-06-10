using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.MainCollections
{
    /// <summary>
    /// Set is: UNIQUE and UNORDERED, because of HASH!
    /// </summary>

    internal static class ExploringSet
    {
        internal static void MainSet()
        {
            PessoaSet[] pessoas = new[]
            {
            new PessoaSet(id: "1", nome: "Enzo", idade: 21),
            new PessoaSet("2", "Polck", 22),
            new PessoaSet("3", "Pedro", 21)
            };

            ISet<PessoaSet> conjuntoPessoas = new HashSet<PessoaSet>(pessoas);


            conjuntoPessoas.Add(new PessoaSet("1", "Klaus", 21));
            //Não é adicionado, porque o GetHash é o Id. Já tem objeto de Id 1

            foreach (PessoaSet p in conjuntoPessoas)
            {
                Console.WriteLine(p.Id);
            }
        }
    }

    public class PessoaSet
    {
        private string _id;
        private string _nome;
        private int _idade;

        public string Nome
        {
            get => _nome;
        }

        public string Id { get => _id; }

        public PessoaSet(string id, string nome, int idade)
        {
            _id = id;
            _nome = nome;
            _idade = idade;
        }

        public override bool Equals(object? obj)
        {
            var outraPessoa = obj as PessoaSet;
            if (obj is null)
                return false;
            return outraPessoa.Id == Id;
        }

        public override string? ToString()
        {
            return string.Join(", ", _id, _nome, _idade);
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }
    }
}
