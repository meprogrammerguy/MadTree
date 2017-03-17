using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadTree
{
    class Node
    {
        public int Seed;
        public int ActualScore;
        public int PredictedScore;
        public string Team;
        public Node Winner;
        public Node TeamA;
        public Node TeamB;
        public void Display()
        {
            Console.Write("[");
            Console.Write(Seed);
            Console.Write("] ");
        }
    }
}
