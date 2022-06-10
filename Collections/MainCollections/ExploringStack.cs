using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.MainCollections
{
    internal class ExploringStack
    {

        /// <summary>
        /// Lógica da Stack: Last In, First Out. (LIFO)
        /// Ex: Buttons "Voltar" e de "Prosseguir" entre sites no browser
        /// </summary>
        internal static void MainStack()
        {
            var browser = new Browser();

            browser.NavigateTo("www.google.com");
            browser.NavigateTo("www.facebook.com");
            browser.NavigateTo("www.twitter.com");

            Console.WriteLine("\n\n");
            browser.GoForward();
            browser.GoBack();
            browser.GoForward();

        }


    }
    internal class Browser
    {
        private string? _currentAddr;

        private readonly Stack<string> _history = new();
        private readonly Stack<string> _forward = new();

        internal void NavigateTo(string url)
        {
            if (!string.IsNullOrEmpty(_currentAddr))
                _history.Push(_currentAddr);

            _currentAddr = url;
            ShowCurrentPage();
        }

        internal void GoBack()
        {
            if (_history.Any())
            {
                Console.WriteLine("Voltou!");
                _forward.Push(_currentAddr);
                _currentAddr = _history.Pop();
            }
            ShowCurrentPage();
        }

        internal void GoForward()
        {
            if (_forward.Any())
            {
                Console.WriteLine("Avançou!");
                _currentAddr = _forward.Pop();
                _history.Push(_currentAddr);
            }
            ShowCurrentPage();
        }

        internal void ShowCurrentPage() => Console.WriteLine("Página atual: " + _currentAddr);
    }
}