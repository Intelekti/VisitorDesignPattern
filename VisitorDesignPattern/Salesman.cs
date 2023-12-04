using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace VisitorDesignPattern
{
    // Make sure the access modifier is 'public'
    public class Salesman : IVisitor
    {
        public string Name { get; set; }

        public Salesman(string name)
        {
            Name = name;
        }

        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine($"Salesman: {Name} give a school bag to the child: {kid.KidName}");
        }
    }
}

