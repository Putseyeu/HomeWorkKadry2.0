using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkKatry2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dossier = new Dictionary<string, string>();
            string userInput = "";

            while (userInput != "4")
            {
                Console.WriteLine("Пункты меню:\n" +
                    "1) добавить досье.\n" +
                    "2) вывести всё досье.\n" +
                    "3) удалить досье.\n" +
                    "4) выход из приложения.");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddDossier(dossier);
                        break;
                    case "2":
                        ShowDossier(dossier);
                        break;
                    case "3":
                        DeleteDossier(dossier);
                        break;
                }
            }
        }

        static void AddDossier(Dictionary<string, string> dossier)
        {
            Console.WriteLine("Добавитье ФИО в досье.");
            string fullNames = Console.ReadLine();
            if (dossier.ContainsKey(fullNames))
            {
                Console.WriteLine("Дынные ИФО уже внесены в досье");
            }
            else
            {
                Console.WriteLine("Добавитье профессию в досье.");
                string profession = Console.ReadLine();
                dossier.Add(fullNames, profession);
            }            
        }

        static void ShowDossier(Dictionary<string, string> dossier)
        {
            if (dossier.Count == 0)
            {
                Console.WriteLine("Досье не заполнено");
            }
            else
            {
                foreach (var item in dossier)
                {
                    Console.WriteLine($"ФИО - {item.Key}- профессия {item.Value}");
                }
            }
        }

        static void DeleteDossier(Dictionary<string, string> dossier)
        {
            Console.WriteLine("Введите ИФО для удаления из досье.");
            string fullNames = Console.ReadLine();
            if (dossier.ContainsKey(fullNames))
            {
                dossier.Remove(fullNames);
                Console.WriteLine($"{fullNames} удален из досье.");
            }
            else
            {
                Console.WriteLine($"ФИО {fullNames} не найдено");
            }
        }
    }
}
