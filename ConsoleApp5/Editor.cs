using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EditorHtml
{
    public static class Editor
    {
        public static void Show() 
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo editor");
            Console.WriteLine("-----------");

            Start();

        }

        public static void Start() 
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Clear();
            Console.WriteLine("---------------");
            Console.WriteLine("DDeseja Salvar o arquivo?");
            Console.WriteLine("1 - SIM");
            Console.WriteLine("2 - NÃO");

            int option = int.Parse(Console.ReadLine());

            var texto = file.ToString();

            switch (option)
            {
                case 1: SalvarArquivo(texto); break;
                case 2: Viewer.Show(file.ToString()); break;
                default: Menu.Show(); break;
            }

          
        }

        public static void SalvarArquivo(string texto)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");

            var path = Console.ReadLine();

            using (var arquivo = new StreamWriter(path)) 
            {
                arquivo.Write(texto);
            }

            Console.Clear();    

            Console.WriteLine($"Arquivo {path} salvo com sucesso");
            Thread.Sleep(3000);
            Menu.Show();
        }
    }
}
