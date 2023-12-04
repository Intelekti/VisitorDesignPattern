using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace VisitorDesignPattern
{
    public class School
    {
        private static readonly List<IElement> Elements;

        static School()
        {
            Elements = new List<IElement>
            {
                new Kid("Ram"),
                new Kid("Sara"),
                new Kid("Pam"),
            };
        }

        public void PerformOperation(IVisitor visitor)
        {
            foreach (var kid in Elements)
            {
                kid.Accept(visitor);
            }
        }
    }
}

