using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_10lib;

namespace Lab11
{
    public class TestCollections
    {
        public LinkedList<Goods> listP = new();
        public LinkedList<string> listS = new();
        public Dictionary<Goods, Toy> dicPE = new();
        public Dictionary<string, Toy> dicSE = new();
        public void RandomInit(int count)
        {
            for (int i = 0; i < count; ++i)
            {
                var toy = new Toy();
                toy.RandomInit();
                while (listP.Contains(toy.BaseGood))
                {
                    toy.RandomInit();
                }
                listS.AddLast(toy.ToString());
                listP.AddLast(toy.BaseGood);
                dicSE.Add(toy.ToString(), toy);
                dicPE.Add(toy.BaseGood, toy);
            }

        }
    }
}
