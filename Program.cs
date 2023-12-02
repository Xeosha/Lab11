using Lab_10lib;
using Menu;
using InputKeyboard;
using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace Lab11
{
    public class Program
    {
        public static T GetCenterValue<T>(LinkedList<T> listG)
        {
            int center = listG.Count / 2;
            var item = listG.First; 
            for(int i = 0; i < center; i++)
                item = item.Next;
            return item.Value;
        }

        public static void RandomInitTest(ref TestCollections test)
        {
            test.RandomInit(EnterKeybord.TypeInteger("Введите размер: ", 0));
        }

        public static void DisplayTime(TestCollections test)
        {
            if (test.Count == 0) 
            {
                Console.WriteLine("Пожалуйста, заполните TestCollections");
                return;
            }

            Console.WriteLine("Поиск первого элемента в коллекции LinkedList<Goods>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkList(test.listG, (Goods)test.listG.First.Value.Clone())}");
            Console.WriteLine("Поиск центрального элемента в коллекции LinkedList<Goods>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkList(test.listG, (Goods)GetCenterValue(test.listG).Clone())}");
            Console.WriteLine("Поиск последнего элемента в коллекции LinkedList<Goods>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkList(test.listG, (Goods)test.listG.Last.Value.Clone())}");
            Console.WriteLine("Поиск элемента не входящего в коллекцию LinkedList<Goods>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkList(test.listG, new Goods())}");
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
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicGT, (Goods)test.dicGT.Keys.ToArray()[0].Clone())}");
            Console.WriteLine("Поиск центрального ключа в коллекции Dictionary<Goods,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicGT, (Goods)test.dicGT.Keys.ToArray()[test.dicGT.Keys.Count / 2].Clone())}");
            Console.WriteLine("Поиск последнего ключа в коллекции Dictionary<Goods,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicGT, (Goods)test.dicGT.Keys.ToArray()[test.dicGT.Keys.Count - 1].Clone())}");
            Console.WriteLine("Поиск ключа не входящего в коллекцию Dictionary<Goods,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicGT, new Goods())}");
            Console.WriteLine();

            Console.WriteLine("Поиск первого ключа в коллекции Dictionary<string,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicST, (string)test.dicST.Keys.ToArray()[0].Clone())}");
            Console.WriteLine("Поиск центрального ключа в коллекции Dictionary<string,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicST, (string)test.dicST.Keys.ToArray()[test.dicST.Keys.Count / 2].Clone())}");
            Console.WriteLine("Поиск последнего ключа в коллекции Dictionary<string,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicST, (string)test.dicST.Keys.ToArray()[test.dicST.Keys.Count - 1].Clone())}");
            Console.WriteLine("Поиск ключа не входящего в коллекцию Dictionary<string,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicST, "")}");
            Console.WriteLine();
            
            Console.WriteLine("Поиск первого элемента в коллекции Dictionary<string,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicST, (Toy)test.dicST.Values.ToArray()[0].Clone())}");
            Console.WriteLine("Поиск центрального элемента в коллекции Dictionary<string,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicST, (Toy)test.dicST.Values.ToArray()[test.listG.Count / 2].Clone())}");
            Console.WriteLine("Поиск последнего элемента в коллекции Dictionary<string,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicST, (Toy)test.dicST.Values.ToArray()[test.listG.Count - 1].Clone())}");
            Console.WriteLine("Поиск элемента не входящего в коллекцию Dictionary<string,Toy>...");
            Console.WriteLine($"Время = {TimeWork.TimeOfWorkDictionary(test.dicST, new Toy())}");
    
        }

        static void DisplayTestCollection(TestCollections test)
        {
            if (test.listS.Count == 0)
                Console.WriteLine("TestCollections пуст.");
            foreach (var item in test.listS) 
                Console.WriteLine(item + "\n");

        }

        static void DisplayDelItem(TestCollections test)
        {
            var toy = new Toy();
            toy.Init();
            if (test.DeleteElem(toy))
                Console.WriteLine("Игрушка удалена.");
            else
                Console.WriteLine("Такой игрушки нет.");
        }

        static void DisplayAddItem(TestCollections test)
        {
            var toy = new Toy();
            toy.Init();
            if (test.Add(toy))
                Console.WriteLine("Игрушка добавлена.");
            else
                Console.WriteLine("Не удалось добавить игрушку.");
        }

        static void Main()
        {

            var test = new TestCollections();

            var dialog = new Dialog("Лабораторная работа №11");

            dialog.AddOption("Создать TestCollections", () => RandomInitTest(ref test));
            dialog.AddOption("Время поиска в различных коллекциях", () => DisplayTime(test));
            dialog.AddOption("Добавление элемента", () => DisplayAddItem(test));
            dialog.AddOption("Удаление элемента", () => DisplayDelItem(test));
            dialog.AddOption("Вывод элементов коллекций", () => DisplayTestCollection(test));

            dialog.Start();
        }
    }
}














