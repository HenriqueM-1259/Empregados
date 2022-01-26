using System;
using System.Collections.Generic;
using Emplyers.Entities;
namespace Emplyers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.WriteLine("=-=-=-=-=Cadastro de Empregados=-=-=-=-=");
            Console.Write("Entre com a quatidade de empregados: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Empregado {i}");
                Console.WriteLine();
                Console.Write("Terceirizados ? (S/N): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor por horas: ");
                double valuePerHora = double.Parse(Console.ReadLine());
                if (ch == 's')
                {
                    Console.Write("Depesas adicionais: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHora, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHora));
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Pagamentos: ");
            foreach (Employee item in list)
            {
                Console.WriteLine(item.Name + " - $ " + item.Payment().ToString("F2"));
            }
        }
    }
}
