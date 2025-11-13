using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Bubblegenerator
{
    internal class SoapBubble : Bubble, IPoppable
    {
        public override void Bubb()
        {
            Console.WriteLine("Soap blub");
        }

        public void Pop()
        {
            Console.WriteLine("POP!!");
        }
    }
}
