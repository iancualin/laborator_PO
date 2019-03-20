using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            //adauga elemente in stiva
            st.Push(1);
            st.Push(2);
            st.Push(3);

            // elimina un elem din stiva
            int v = st.Pop();

            st.Push(4);

            //intoarce elementul din varful stivei fara al elimina 
            Console.WriteLine(st.Peek());

             
            //numara elem din stiva
            Console.WriteLine(st.Count);
            
            //nr de elemente din stiva
            Console.WriteLine(st.Capacity);

            st.Pop();
            st.Pop();

            int value;
            bool result = st.TryPeek(out value);
            st.Pop();
            Console.WriteLine(st.IsEmpty);
            Console.WriteLine(st.IsFull);
            //instructiuneaa va lansa exceptia
            st.Pop();
        }
    }
}
//