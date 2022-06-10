using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.MainCollections
{
    /// <summary>
    /// Remoção e inserção rápida em qualquer lugar ! 
    /// Ela não é uma estrutura sequencial, e portanto, não precisa ser "reorganizada" a cada
    /// alteração em seus elementos. Somente os nodes que devem ser reapontados
    /// Porém, ela é unordered, pelo exato motivo. Não dá pra ordernar
    /// A busca também é feita de maneira linear, porque você tem que percorrer as referências de cada LinkedListNode
    /// 
    /// LinkedList é uma lista duplamente encadeada no .NET (Node.previous e Node.next)
    /// </summary>
    /// 
    /// Second answer!
    /// <seealso cref="https://stackoverflow.com/questions/169973/when-should-i-use-a-list-vs-a-linkedlist"/>
    internal class ExploringLinkedList
    {

        internal static void MainLinked()
        {
            var week = new string[]
            {
                "Domingo",
                "Segunda",
                "Terça",
                "Quarta",
                "Quinta",
                "Sexta",
                "Sábado"
            };

            var linkedList = new LinkedList<string>();
            var d1 = linkedList.AddFirst(week[0]); // D1 is a linked list node
            var d2 = linkedList.AddAfter(d1, week[1]); // d1 <=> d2
            var d3 = linkedList.AddAfter(d1, week[2]); // d1 <=> d3 <=> d2 (reapontted

            // Busca linear O(n)
            Console.WriteLine(linkedList.Find(week[1])?.Value ?? "Não encontrado");


            Console.WriteLine("\n");
            foreach (var node in linkedList)
            {
                Console.WriteLine(node);
            }

        }
    }
}
