using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введите Ваше ФИО: ");
        string fio = Console.ReadLine();
        Console.WriteLine($"Приветствую тебя - {fio}");
    }
}