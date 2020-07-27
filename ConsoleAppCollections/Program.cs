using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> abbreviationsDictionary = new Dictionary<string, string>();
            abbreviationsDictionary.Add("БГУ", "Белорусский Государственный Университет");
            abbreviationsDictionary.Add("БГЭУ", "Белорусский Государственный Экономический Университет");

            string abbr = "БГУ";

            Console.WriteLine($"Является студентом {abbreviationsDictionary[abbr]}.");

            foreach(var item in abbreviationsDictionary)
            {
                Console.WriteLine($"Аббревиатура для {item.Value} - {item.Key}");
            }

            return;

            // CRUD - create, read, update, delete

            List<string> students = new List<string>() { "Петров", "Сидоров", "Леонов", "Захарова", "Иванов" };

            while (true)
            {
                Console.WriteLine("Введите команду: c - create, r - read, u - update, d - delete, s - search, q - quit");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "c":
                        //create
                        Console.WriteLine("Введите имя студента:");
                        string newStudent = Console.ReadLine();
                        students.Add(newStudent);
                        break;

                    case "r":
                        //read
                        int i = 1;
                        Console.WriteLine("Список студентов:");
                        foreach (var student in students)
                            Console.WriteLine($"{i++}. {student}");
                        Console.WriteLine("");
                        break;

                    case "u":
                        //update
                        Console.WriteLine("Введите номер студента:");
                        int numberToUpdate = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите имя студента:");
                        var updatedStudent = Console.ReadLine();
                        students[numberToUpdate - 1] = updatedStudent;
                        break;

                    case "d":
                        //delete
                        Console.WriteLine("Введите номер студента:");
                        int numberToDelete = int.Parse(Console.ReadLine());
                        students.RemoveAt(numberToDelete - 1);
                        break;

                    case "s":
                        Console.WriteLine("Введите строку поиска:");
                        var search = Console.ReadLine();

                        var resultCollection = students.Where(student => student.Contains(search, 
                            StringComparison.OrdinalIgnoreCase));
                        
                        Console.WriteLine("Результаты поиска:");
                        if (resultCollection.Any())
                            foreach (var student in resultCollection)
                                Console.WriteLine(student.Replace(search, search.ToUpper(), StringComparison.OrdinalIgnoreCase));
                        else
                            Console.WriteLine("Ничего не найдено");

                        break;


                    case "q":
                        return;

                    default:
                        Console.WriteLine("Неверная команда, введите еще раз.");
                        break;
                }
            }
        }
    }
}
