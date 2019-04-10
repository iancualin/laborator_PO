using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a queue of capacity 4  
            Queu q = new Queu(4);

            // print Queue elements  
            q.queueDisplay();

            // inserting elements in the queue  
            q.queueEnqueue(20);
            q.queueEnqueue(30);
            q.queueEnqueue(40);
            q.queueEnqueue(50);

            // print Queue elements  
            q.queueDisplay();

            // insert element in the queue  
            q.queueEnqueue(60);

            // print Queue elements  
            q.queueDisplay();

            q.queueDequeue();
            q.queueDequeue();
            Console.Write("\n\nafter two node deletion\n\n");

            // print Queue elements  
            q.queueDisplay();

            // print front of the queue  
            q.queueFront();
        }
    }
}
