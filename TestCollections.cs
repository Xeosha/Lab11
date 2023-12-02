using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Lab_10lib;

namespace Lab11
{
    public class TestCollections
    {
        private int count = 0;
        public LinkedList<Goods> listG = new();
        public LinkedList<string> listS = new();
        public Dictionary<Goods, Toy> dicGT = new();
        public Dictionary<string, Toy> dicST = new();

        public int Count { get { return count; } }

        public void RandomInit(int count)
        {
            for (int i = 0; i < count; ++i)
            {
                var toy = new Toy();
                toy.RandomInit();
                while (listG.Contains(toy.BaseGood))
                {
                    toy.RandomInit();
                }
                listS.AddLast(toy.ToString());
                listG.AddLast(toy.BaseGood);
                dicST.Add(toy.ToString(), toy);
                dicGT.Add(toy.BaseGood, toy);
                this.count++; 
            }
        }

        public bool Add(Toy toy)
        {
            if(listG.Contains(toy.BaseGood))
                return false;
            
            listS.AddLast(toy.ToString());
            listG.AddLast(toy.BaseGood);
            dicST.Add(toy.ToString(), toy);
            dicGT.Add(toy.BaseGood, toy);
            this.count++;
            return true;
        }

        public bool DeleteElem(Toy toy)
        {
            if (!listG.Contains(toy.BaseGood))
                return false;
            listG.Remove(toy.BaseGood);
            listS.Remove(toy.ToString());
            dicGT.Remove(toy.BaseGood);
            dicST.Remove(toy.ToString());
            this.count--;
            return true;
            
        }
    }
}
