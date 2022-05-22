using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal static class MinimumRemoveParantheses
    { 
        internal static string Solution(string s)
        {

            // "a)b(c)d
            StringBuilder sb = new();
            int balance = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    balance++;
                else if (s[i] == ')')
                {
                    if (balance == 0) continue;
                    balance--;
                }
                sb.Append(s[i]);
            }
            StringBuilder sbResult = new();
            if (balance > 0)
            {
                for (int j = sb.Length - 1; j >= 0; j--)
                {
                    if (sb[j] == '(')
                    {
                        balance -= 1;
                        if (balance >= 0) continue; 
                    }
                    sbResult.Append(sb[j]);
                }

                var resultado = (sbResult.ToString().Reverse()).ToArray();
                return new string(resultado);
            }
            else
                return sb.ToString();
        }
    }
}
