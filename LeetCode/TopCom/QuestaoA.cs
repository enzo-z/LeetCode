using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TopCom
{
    /// <summary>
    /// <a href="https://drive.google.com/file/d/1QE4PiHmYFz-V0KtCh8di46VfZwrZIjSB/view?usp=sharing">Questão original (PT-BR)</a>
    /// </summary>
    public class QuestaoA
    {
        public static void Start()
        {
            try
            {
                int n = GetQntdValores();
                if (n == 0)
                {
                    Console.WriteLine("false");
                    return;
                }

                var mdcs = GetMaioresDivisoresComuns(n);
                VerificaCoprimos(mdcs);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PrintErrorMsg();
            }
        }
        private static void VerificaCoprimos(List<int> mdcs)
        {
            foreach (var mdc in mdcs)
            {
                if (mdc == 1)
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false");
            }
        }
        public static List<int> GetMaioresDivisoresComuns(int n)
        {
            var mdcs = new List<int>();
            var doisNum = new int[2];
            for (int i = 0; i < n; i++)
            {
                string? inputValores = Console.ReadLine();
                doisNum = ValidaInput(inputValores);
                int maiorDivisorComum = GetMaiorDivisorComum(doisNum[0], doisNum[1]);
                mdcs.Add(maiorDivisorComum);
            }
            return mdcs;
        }
        public static int GetMaiorDivisorComum(int a, int b)
        {
            if (a < b)
            {
                int aux = a;
                a = b;
                b = aux;
            }

            return (b == 0) ? a : GetMaiorDivisorComum(b, a % b);
        }
        public static int[] ValidaInput(string? valores)
        {
            if (valores is null) throw new ArgumentNullException(nameof(valores));

            var arrValores = valores.Split(" ");

            if (arrValores.Length < 2) throw new Exception("Precisa passar dois valores!");

            int n1 = 0;
            int n2 = 0;

            n1 = Convert.ToInt32(arrValores[0]);
            n2 = Convert.ToInt32(arrValores[1]);

            return new int[] { n1, n2 };
        }
        public static int GetQntdValores()
        {
            Console.WriteLine("Digite n (qntd de linhas a serem lidas): ");
            int n = 0;
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 1000) throw new Exception("n deve ser <= a 1000");

            return n;
        }
        public static void PrintErrorMsg() => Console.WriteLine("Feriu as regras! Invalido!");
    }
}
