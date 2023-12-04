using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public interface IVisitor
    {
        void Visit(IElement element);
    }
}

