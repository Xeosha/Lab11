using Lab_10lib;
using Menu;
using InputKeyboard;
using System;
using System.Collections.Generic;

namespace Lab11
{
    public class Program
    {
        public static T GetCenterValue<T>(LinkedList<T> listP)
        {
            var slow = listP.First;
            var fast = listP.Last;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow.Value;
        }


        public static void RandomInitTest(ref TestCollections test)
        {
            test.RandomInit(EnterKeybord.TypeInteger("Введите размер: ", 0));
        }

        public static void DisplayTime(TestCollections test)
        {
            if(test.listP.Count + test.listS.Count == 0)
            {
                Console.WriteLine("Пожалуйста, заполните TestCollections");
                return;
            }

            Console.WriteLine("Поиск первого элемента в коллекции LinkedList<Goods>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkList(test.listP, (Goods)test.listP.First.Value.Clone())}");
            Console.WriteLine("Поиск центрального элемента в коллекции LinkedList<Goods>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkList(test.listP, (Goods)GetCenterValue(test.listP).Clone())}");
            Console.WriteLine("Поиск последнего элемента в коллекции LinkedList<Goods>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkList(test.listP, (Goods)test.listP.Last.Value.Clone())}");
            Console.WriteLine("Поиск элемента не входящего в коллекцию LinkedList<Goods>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkList(test.listP, new Goods())}");
            Console.WriteLine();

            Console.WriteLine("Поиск первого элемента в коллекции LinkedList<string>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkList(test.listS, (string)test.listS.First.Value.Clone())}");
            Console.WriteLine("Поиск центрального элемента в коллекции LinkedList<string>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkList(test.listS, (string)GetCenterValue(test.listS).Clone())}");
            Console.WriteLine("Поиск последнего элемента в коллекции LinkedList<string>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkList(test.listS, (string)test.listS.Last.Value.Clone())}");
            Console.WriteLine("Поиск элемента не входящего в коллекцию LinkedList<string>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkList(test.listS, "")}");
            Console.WriteLine();

            Console.WriteLine("Поиск первого ключа в коллекции Dictionary<Goods,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicPE, (Goods)test.dicPE.Keys.ToArray()[0].Clone())}");
            Console.WriteLine("Поиск центрального ключа в коллекции Dictionary<Goods,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicPE, (Goods)test.dicPE.Keys.ToArray()[test.dicPE.Keys.Count / 2].Clone())}");
            Console.WriteLine("Поиск последнего ключа в коллекции Dictionary<Goods,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicPE, (Goods)test.dicPE.Keys.ToArray()[test.dicPE.Keys.Count - 1].Clone())}");
            Console.WriteLine("Поиск ключа не входящего в коллекцию Dictionary<Goods,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicPE, new Goods())}");
            Console.WriteLine();

            Console.WriteLine("Поиск первого ключа в коллекции Dictionary<string,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicSE, (string)test.dicSE.Keys.ToArray()[0].Clone())}");
            Console.WriteLine("Поиск центрального ключа в коллекции Dictionary<string,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicSE, (string)test.dicSE.Keys.ToArray()[test.dicSE.Keys.Count / 2].Clone())}");
            Console.WriteLine("Поиск последнего ключа в коллекции Dictionary<string,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicSE, (string)test.dicSE.Keys.ToArray()[test.dicSE.Keys.Count - 1].Clone())}");
            Console.WriteLine("Поиск ключа не входящего в коллекцию Dictionary<string,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicSE, "")}");
            Console.WriteLine();

            Console.WriteLine("Поиск первого элемента в коллекции Dictionary<string,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicSE, (Toy)test.dicSE.Values.ToArray()[0].Clone())}");
            Console.WriteLine("Поиск центрального элемента в коллекции Dictionary<string,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicSE, (Toy)test.dicSE.Values.ToArray()[test.listP.Count / 2].Clone())}");
            Console.WriteLine("Поиск последнего элемента в коллекции Dictionary<string,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicSE, (Toy)test.dicSE.Values.ToArray()[test.listP.Count - 1].Clone())}");
            Console.WriteLine("Поиск элемента не входящего в коллекцию Dictionary<string,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicSE, new Toy())}");
        }


        static void Main()
        {

            var test = new TestCollections();

            var dialog = new Dialog("Лабораторная работа №11");

            dialog.AddOption("Добавить элементы", () => RandomInitTest(ref test));
            dialog.AddOption("Время поиска в различных коллекциях", () => DisplayTime(test));
            dialog.Start();
        }
    }
}














