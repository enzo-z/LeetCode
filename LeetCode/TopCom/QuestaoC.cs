using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TopCom
{

    /// <summary>
    /// <a href="https://drive.google.com/file/d/1sBcVs8a4nVmBU-A5Z093LJOQpBV5akcw/view?usp=sharing">Questão original (PT-BR)</a>
    /// </summary>
    public class QuestaoC
    {
        public static void Start()
        {
            try
            {
                int qntdInputs = GetQntdValores();
                if (qntdInputs == 0) Console.WriteLine("Nenhum input");
                for (int i = 0; i < qntdInputs; i++)
                {
                    var input = Console.ReadLine();
                    string balanceamento = GetBalanceamento(input);
                    Console.WriteLine(balanceamento);
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Você não digitou um número!");
                Start();
            }
        }

        public static int GetQntdValores()
        {
            Console.WriteLine("Digite o número inputs (n): ");
            int n = 0;
            n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        public static string GetBalanceamento(string? input)
        {
            if (input == null) return "Nenhum parentesis. Balanceada";
            
            int balanceamento = 0;
            var abertos = new Stack<char>();
            foreach (var character in input.ToCharArray())
            {
                if (character == '(' || character == '[' || character == '{')
                    abertos.Push(character);
                else if (character == ')' || character == ']' || character == '}')
                {
                    if (balanceamento <= 0) return "Erro de balanceamento";
                    
                    else if (!IsAninhado(abertos.Pop(), character))
                        return "Erro de balanceamento";
                }
                balanceamento = abertos.Count;
            }
            if (balanceamento != 0) return "Erro de balanceamento";

            return "Balanceada";
        }
        public static bool IsAninhado(char lastOpen, char closing)
        {
            if(lastOpen == '(')
                return closing == ')';
            if (lastOpen == '{')
                return closing == '}';
            if (lastOpen == '[')
                return closing == ']';
            return false;
        }

    }
}
