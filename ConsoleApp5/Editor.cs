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

            Console.WriteLine("---------------");
            Console.WriteLine(" Deseja Salvar o arquivo?");

            var texto = file.ToString();


            SalvarArquivo(texto);
           
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

            Console.WriteLine($"Arquivo {path} salvo com sucesso");
        }
    }
}
